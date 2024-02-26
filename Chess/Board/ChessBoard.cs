using System;
using System.Drawing;
using System.Media;
using System.Threading.Tasks;
using System.Windows.Forms;
using Chess.Models;

namespace Chess
{
    public partial class ChessBoard : UserControl
    {
        private const int BOARD_SIZE = 8;
        private Cell[,] board = new Cell[BOARD_SIZE, BOARD_SIZE];
        private DraggingCanvas overlay;
        public Figure EnPassantTarget { get; set; }
        public GameScreen gameScreen;

        public Player playingPlayer;
        public SoundPlayer RaiseFigureSound;
        public SoundPlayer PlaceFigureSound;
        public SoundPlayer PromotionSound;
        public SoundPlayer EnPassantSound;
        public SoundPlayer CastlingSound;

        public bool EnPassantPerformed { get; set; }
        public bool CastlingPerformed { get; set; }

        public ChessBoard()
        {
            this.Visible = false;
            this.DoubleBuffered = true;
            InitializeComponent();
            this.SetStyle(ControlStyles.UserPaint |
                          ControlStyles.AllPaintingInWmPaint |
                          ControlStyles.OptimizedDoubleBuffer |
                          ControlStyles.ResizeRedraw, true);
            this.UpdateStyles();

            this.EnPassantPerformed = false;
            this.overlay = new DraggingCanvas(this);
            this.Controls.Add(this.overlay);
            this.BackgroundImage = new Lazy<Image>(() => Properties.Resources.Chessboard).Value;
            this.BackgroundImageLayout = ImageLayout.Stretch;
            this.overlay.Size = this.Size;
            this.overlay.Location = new Point(0, 0);
            this.Controls.SetChildIndex(this.overlay, 0);
            this.FillGrid();
            this.RaiseFigureSound = new SoundPlayer(Properties.Resources.raiseFigure);
            this.PlaceFigureSound = new SoundPlayer(Properties.Resources.placeFigure);
            this.PromotionSound = new SoundPlayer(Properties.Resources.promotion);
            this.EnPassantSound = new SoundPlayer(Properties.Resources.enPassant);
            this.CastlingSound = new SoundPlayer(Properties.Resources.castling);
            this.Visible = true;
        }

        private void FillGrid()
        {
            for (int x = 0; x < BOARD_SIZE; x++)
            {
                for (int y = 0; y < BOARD_SIZE; y++)
                {
                    Cell cell = new Cell(x, y);
                    this.Controls.Add(cell.Panel);
                    this.board[x, y] = cell;
                }
            }
        }

        // Initial board setup
        private void InitBoard()
        {
            // Black figures
            this.GetCell('a', 8).Figure = new Rook(FigureColor.Black);
            this.GetCell('b', 8).Figure = new Knight(FigureColor.Black);
            this.GetCell('c', 8).Figure = new Bishop(FigureColor.Black);
            this.GetCell('d', 8).Figure = new Queen(FigureColor.Black);
            this.GetCell('e', 8).Figure = new King(FigureColor.Black);
            this.GetCell('f', 8).Figure = new Bishop(FigureColor.Black);
            this.GetCell('g', 8).Figure = new Knight(FigureColor.Black);
            this.GetCell('h', 8).Figure = new Rook(FigureColor.Black);
            // Black Pawns
            this.GetCell('a', 7).Figure = new Pawn(FigureColor.Black);
            this.GetCell('b', 7).Figure = new Pawn(FigureColor.Black);
            this.GetCell('c', 7).Figure = new Pawn(FigureColor.Black);
            this.GetCell('d', 7).Figure = new Pawn(FigureColor.Black);
            this.GetCell('e', 7).Figure = new Pawn(FigureColor.Black);
            this.GetCell('f', 7).Figure = new Pawn(FigureColor.Black);
            this.GetCell('g', 7).Figure = new Pawn(FigureColor.Black);
            this.GetCell('h', 7).Figure = new Pawn(FigureColor.Black);

            // White Pawns
            this.GetCell('a', 2).Figure = new Pawn(FigureColor.White);
            this.GetCell('b', 2).Figure = new Pawn(FigureColor.White);
            this.GetCell('c', 2).Figure = new Pawn(FigureColor.White);
            this.GetCell('d', 2).Figure = new Pawn(FigureColor.White);
            this.GetCell('e', 2).Figure = new Pawn(FigureColor.White);
            this.GetCell('f', 2).Figure = new Pawn(FigureColor.White);
            this.GetCell('g', 2).Figure = new Pawn(FigureColor.White);
            this.GetCell('h', 2).Figure = new Pawn(FigureColor.White);
            // White figures
            this.GetCell('a', 1).Figure = new Rook(FigureColor.White);
            this.GetCell('b', 1).Figure = new Knight(FigureColor.White);
            this.GetCell('c', 1).Figure = new Bishop(FigureColor.White);
            this.GetCell('d', 1).Figure = new Queen(FigureColor.White);
            this.GetCell('e', 1).Figure = new King(FigureColor.White);
            this.GetCell('f', 1).Figure = new Bishop(FigureColor.White);
            this.GetCell('g', 1).Figure = new Knight(FigureColor.White);
            this.GetCell('h', 1).Figure = new Rook(FigureColor.White);
        }

        private void ChessBoard_Load(object sender, EventArgs e)
        {
            this.Size = new Size(BOARD_SIZE * Cell.SQUARE_SIZE, BOARD_SIZE * Cell.SQUARE_SIZE);
            this.InitBoard();
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;

            for (int x = 0; x < BOARD_SIZE; x++)
            {
                for (int y = 0; y < BOARD_SIZE; y++)
                {
                    Cell cell = this.board[x, y];
                    if (cell.Figure != null && cell.Figure != this.overlay.DraggedFigure)
                    {
                        g.DrawImage(cell.Figure.Sprite, cell.Figure.ImageLocation.X, cell.Figure.ImageLocation.Y, Cell.SQUARE_SIZE, Cell.SQUARE_SIZE);
                    }
                }
            }
        }
        private int ConvertColumnCharToIndex(char column)
        {
            return column - 'a';
        }

        private int ConvertRowNumToIndex(int rowNumber)
        {
            return BOARD_SIZE - rowNumber;
        }

        public Cell GetCell(char columnChar, int rowNumber)
        {
            int columnIndex = ConvertColumnCharToIndex(columnChar);
            int rowIndex = ConvertRowNumToIndex(rowNumber);
            return board[columnIndex, rowIndex];
        }

        public string GetCellName(int x, int y)
        {
            return ((char)('a' + x)).ToString() + (8 - y).ToString();
        }

        public Figure GetFigure(int x, int y)
        {
            return this.board[x, y].Figure;
        }
        public void PlaceFigure(Figure figure, int x, int y)
        {
            if (figure != null && this.playingPlayer != null && this.playingPlayer.PickedColor == figure.PieceColor)
            {
                int cellX = x / Cell.SQUARE_SIZE;
                int cellY = y / Cell.SQUARE_SIZE;

                if (figure.Name != FigureType.Pawn)
                {
                    this.EnPassantTarget = null;
                }

                if (figure.CanMove(cellX, cellY))
                {
                    this.board[figure.X, figure.Y].Figure = null;

                    if (this.board[cellX, cellY].Figure != null)
                    {
                        this.gameScreen.discardFigure(this.board[cellX, cellY].Figure);
                    }

                    Move move = new Move
                    {
                        GameId = this.gameScreen.game.Id,
                        PlayerId = this.playingPlayer.playerModel.Id,
                        From = this.GetCellName(figure.X, figure.Y),
                        To = this.GetCellName(cellX, cellY),
                        Time = DateTime.Now,
                        figureName = figure.Name
                    };

                    this.gameScreen.Database.SaveMove(move);

                    this.board[cellX, cellY].Figure = figure;
                    figure.X = cellX;
                    figure.Y = cellY;

                    if (!figure.HasMoved)
                    {
                        figure.HasMoved = true; // Set the figure as moved at least once. Used for castling.
                    }

                    if (this.gameScreen != null) this.gameScreen.SetPlayingPlayer();

                    if (this.EnPassantPerformed)
                    {
                        this.EnPassantSound.Play();
                        this.EnPassantPerformed = false;
                        this.ShowEnPassantExplanation();
                    }
                    else if (this.CastlingPerformed)
                    {
                        this.CastlingSound.Play();
                        this.CastlingPerformed = false;
                        this.ShowCastlingExplanation();
                    }
                    else
                    {
                        this.PlaceFigureSound.Play();
                    }

                    if (figure.Name == FigureType.Pawn)
                    {
                        if (figure.PieceColor == FigureColor.White && figure.Y == 0)
                        {
                            (figure as Pawn).Promote();
                        }
                        else if (figure.PieceColor == FigureColor.Black && figure.Y == 7)
                        {
                            (figure as Pawn).Promote();
                        }
                    }
                }
                else
                {
                    this.board[figure.X, figure.Y].Figure = figure;
                }
            }
        }
        public void PromotePawn(Figure pawn, FigureType figureType)
        {
            Figure newFigure = null;
            switch (figureType)
            {
                case FigureType.Queen:
                    newFigure = new Queen(pawn.PieceColor);
                    break;
                case FigureType.Rook:
                    newFigure = new Rook(pawn.PieceColor);
                    break;
                case FigureType.Bishop:
                    newFigure = new Bishop(pawn.PieceColor);
                    break;
                case FigureType.Knight:
                    newFigure = new Knight(pawn.PieceColor);
                    break;
            }
            newFigure.X = pawn.X;
            newFigure.Y = pawn.Y;
            newFigure.ImageLocation = pawn.ImageLocation;
            newFigure.Board = pawn.Board;
            this.board[pawn.X, pawn.Y].Figure = newFigure;
            this.PromotionSound.Play();
        }
        public void PerformEnPassant()
        {
            this.board[this.EnPassantTarget.X, this.EnPassantTarget.Y].Figure = null;
            this.EnPassantPerformed = true;
        }
        private async void ShowEnPassantExplanation()
        {
            await Task.Delay(3000);
            using (EnPassantExplain enPassantExplain = new EnPassantExplain())
            {
                enPassantExplain.ShowDialog();
            }
        }
        private async void ShowCastlingExplanation()
        {
            await Task.Delay(3000);
            using (CastlingExplain castlingExplain = new CastlingExplain())
            {
                castlingExplain.ShowDialog();
            }
        }
        public void PerformCastling(Figure rook, int x, int y)
        {
            int rookX = rook.X;
            int rookY = rook.Y;
            this.board[rookX, rookY].Figure = null;
            this.board[x, y].Figure = rook;
            rook.X = x;
            rook.Y = y;
            this.CastlingPerformed = true;
        }
    }
    internal class DraggingCanvas : Panel
    {
        private Figure _DraggedFigure;
        private ChessBoard chessBoard;
        public Timer updateTimer;
        public Point figureLastPosition;
        public Figure DraggedFigure
        {
            get
            {
                return this._DraggedFigure;
            }
            set
            {
                this._DraggedFigure = value;
                this.Invalidate();
            }
        }
        public DraggingCanvas(ChessBoard chessBoard)
        {
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer |
                          ControlStyles.AllPaintingInWmPaint |
                          ControlStyles.UserPaint |
                          ControlStyles.SupportsTransparentBackColor, true);
            this.BackColor = Color.Transparent;
            this.DoubleBuffered = true;
            this.chessBoard = chessBoard;
            this.MouseDown += ChessBoard_MouseDown;
            this.MouseMove += ChessBoard_MouseMove;
            this.MouseUp += ChessBoard_MouseUp;
            this.updateTimer = new Timer();
            this.updateTimer.Interval = 20;
            this.updateTimer.Tick += UpdateTimer_Tick;
        }
        private void UpdateTimer_Tick(object sender, EventArgs e)
        {
            Rectangle newPosition = this.GetFigureRectangle(this.DraggedFigure.ImageLocation.X, this.DraggedFigure.ImageLocation.Y);
            Rectangle oldPosition = this.GetFigureRectangle(this.figureLastPosition.X, this.figureLastPosition.Y);
            Rectangle combined = Rectangle.Union(oldPosition, newPosition);
            this.Invalidate(combined);
            this.figureLastPosition = this.DraggedFigure.ImageLocation;
        }
        private void ChessBoard_MouseDown(object sender, MouseEventArgs e)
        {
            Figure draggedFigure = this.chessBoard.GetFigure(e.X / Cell.SQUARE_SIZE, e.Y / Cell.SQUARE_SIZE);
            if (draggedFigure != null && this.chessBoard.playingPlayer != null && this.chessBoard.playingPlayer.PickedColor == draggedFigure.PieceColor)
            {
                this.DraggedFigure = draggedFigure;
                this.figureLastPosition = this.DraggedFigure.ImageLocation;
                this.updateTimer.Start();
                this.chessBoard.RaiseFigureSound.Play();
            }
        }
        private void ChessBoard_MouseMove(object sender, MouseEventArgs e)
        {
            if (this.DraggedFigure != null)
            {
                Cursor.Current = Cursors.Hand;
                Point point = new Point(e.X - this.DraggedFigure.Sprite.Width / 2, e.Y - this.DraggedFigure.Sprite.Height / 2);
                if (this.DraggedFigure.ImageLocation != point)
                {
                    this.DraggedFigure.ImageLocation = point;
                }
            }
            else
            {
                Figure figureBeneath = this.chessBoard.GetFigure(e.X / Cell.SQUARE_SIZE, e.Y / Cell.SQUARE_SIZE);
                if (figureBeneath != null && this.chessBoard.playingPlayer != null && this.chessBoard.playingPlayer.PickedColor == figureBeneath.PieceColor)
                {
                    Cursor.Current = Cursors.Hand;
                }
                else
                {
                    Cursor.Current = Cursors.Default;
                }
            }
        }
        private void ChessBoard_MouseUp(object sender, MouseEventArgs e)
        {
            if (this.DraggedFigure != null)
            {
                this.chessBoard.PlaceFigure(this.DraggedFigure, e.X, e.Y);
                this.DraggedFigure = null;
                this.updateTimer.Stop();
                this.figureLastPosition = new Point(0, 0);
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            if (this.DraggedFigure == null) return;
            if (this.DraggedFigure.ImageLocation != Point.Empty)
            {
                e.Graphics.DrawImage(this.DraggedFigure.Sprite, this.DraggedFigure.ImageLocation.X, this.DraggedFigure.ImageLocation.Y, Cell.SQUARE_SIZE + 6, Cell.SQUARE_SIZE + 6);
            }
        }
       public Rectangle GetFigureRectangle(int pixelX, int pixelY)
        {
            return new Rectangle(pixelX, pixelY, Cell.SQUARE_SIZE + 10, Cell.SQUARE_SIZE + 10);
        }
    }
}
