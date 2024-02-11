using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows;
using System.Media;

namespace Chess
{
    internal class DraggingCanvas : Panel
    {
        private Figure _DraggedFigure;
        private ChessBoard chessBoard;
        public Figure DraggedFigure {
            get
            {
                return this._DraggedFigure;
            }
            set
            {
                this._DraggedFigure = value;
                this.Refresh();
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
        }
        private void ChessBoard_MouseDown(object sender, MouseEventArgs e)
        {
            Figure draggedFigure = this.chessBoard.GetFigure(e.X / Cell.SQUARE_SIZE, e.Y / Cell.SQUARE_SIZE);
            if (draggedFigure != null)
            {
                this.DraggedFigure = draggedFigure;
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
                    this.Refresh();
                }
            } else
            {
                if (this.chessBoard.GetFigure(e.X / Cell.SQUARE_SIZE, e.Y / Cell.SQUARE_SIZE) != null)
                {
                    Cursor.Current = Cursors.Hand;
                } else
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
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            if (this.DraggedFigure == null) return;

            if (this.DraggedFigure.ImageLocation != Point.Empty)
            {
                e.Graphics.DrawImage(this.DraggedFigure.Sprite, this.DraggedFigure.ImageLocation.X, this.DraggedFigure.ImageLocation.Y, Cell.SQUARE_SIZE + 6, Cell.SQUARE_SIZE + 6);

            }
        }
    }
    public partial class ChessBoard : UserControl
    {
        private const int BOARD_SIZE = 8;
        private Cell[,] board = new Cell[BOARD_SIZE, BOARD_SIZE];
        private Figure _SelectedFigure;
        private DraggingCanvas overlay;

        public SoundPlayer RaiseFigureSound;
        public SoundPlayer PlaceFigureSound;
        public SoundPlayer PromotionSound;

        public ChessBoard()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.UserPaint |
                          ControlStyles.AllPaintingInWmPaint |
                          ControlStyles.OptimizedDoubleBuffer |
                          ControlStyles.ResizeRedraw, true);
            this.UpdateStyles();

            this.overlay = new DraggingCanvas(this);
            this.Controls.Add(this.overlay);
            this.DoubleBuffered = true;
            this.FillGrid();
            this.RaiseFigureSound = new SoundPlayer("raiseFigure.wav");
            this.PlaceFigureSound = new SoundPlayer("placeFigure.wav");
            this.PromotionSound = new SoundPlayer("promotion.wav");
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
            // White figures
            this.GetCell('a', 8).Figure = new Rook(FigureColor.White);
            this.GetCell('b', 8).Figure = new Knight(FigureColor.White);
            this.GetCell('c', 8).Figure = new Bishop(FigureColor.White);
            this.GetCell('d', 8).Figure = new Queen(FigureColor.White);
            this.GetCell('e', 8).Figure = new King(FigureColor.White);
            this.GetCell('f', 8).Figure = new Bishop(FigureColor.White);
            this.GetCell('g', 8).Figure = new Knight(FigureColor.White);
            this.GetCell('h', 8).Figure = new Rook(FigureColor.White);
            // White Pawns
            this.GetCell('a', 7).Figure = new Pawn(FigureColor.White);
            this.GetCell('b', 7).Figure = new Pawn(FigureColor.White);
            this.GetCell('c', 7).Figure = new Pawn(FigureColor.White);
            this.GetCell('d', 7).Figure = new Pawn(FigureColor.White);
            this.GetCell('e', 7).Figure = new Pawn(FigureColor.White);
            this.GetCell('f', 7).Figure = new Pawn(FigureColor.White);
            this.GetCell('g', 7).Figure = new Pawn(FigureColor.White);
            this.GetCell('h', 7).Figure = new Pawn(FigureColor.White);

            // Black Pawns
            this.GetCell('a', 2).Figure = new Pawn(FigureColor.Black);
            this.GetCell('b', 2).Figure = new Pawn(FigureColor.Black);
            this.GetCell('c', 2).Figure = new Pawn(FigureColor.Black);
            this.GetCell('d', 2).Figure = new Pawn(FigureColor.Black);
            this.GetCell('e', 2).Figure = new Pawn(FigureColor.Black);
            this.GetCell('f', 2).Figure = new Pawn(FigureColor.Black);
            this.GetCell('g', 2).Figure = new Pawn(FigureColor.Black);
            this.GetCell('h', 2).Figure = new Pawn(FigureColor.Black);
            // Black figures
            this.GetCell('a', 1).Figure = new Rook(FigureColor.Black);
            this.GetCell('b', 1).Figure = new Knight(FigureColor.Black);
            this.GetCell('c', 1).Figure = new Bishop(FigureColor.Black);
            this.GetCell('d', 1).Figure = new Queen(FigureColor.Black);
            this.GetCell('e', 1).Figure = new King(FigureColor.Black);
            this.GetCell('f', 1).Figure = new Bishop(FigureColor.Black);
            this.GetCell('g', 1).Figure = new Knight(FigureColor.Black);
            this.GetCell('h', 1).Figure = new Rook(FigureColor.Black);
        }

        private void ChessBoard_Load(object sender, EventArgs e)
        {
            this.Size = new Size(BOARD_SIZE * Cell.SQUARE_SIZE, BOARD_SIZE * Cell.SQUARE_SIZE);
            this.Location = new Point(30, 100);
            this.InitBoard();
            this.BackgroundImage = Image.FromFile("Board.png");
            this.BackgroundImageLayout = ImageLayout.Stretch;
            this.overlay.Size = this.Size;
            this.overlay.Location = new Point(0, 0);
            this.Controls.SetChildIndex(this.overlay, 0);
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

        public Figure GetFigure(int x, int y)
        {
            return this.board[x, y].Figure;
        }
        public void PlaceFigure(Figure figure, int x, int y)
        {
            if (figure != null)
            {
                int cellX = x / Cell.SQUARE_SIZE;
                int cellY = y / Cell.SQUARE_SIZE;

                if (figure.CanMove(cellX, cellY))
                {
                    this.board[figure.X, figure.Y].Figure = null;
                    this.board[cellX, cellY].Figure = figure;
                    figure.X = cellX;
                    figure.Y = cellY;
                    this.PlaceFigureSound.Play();

                    if (figure.Name == FigureType.Pawn)
                    {
                        if (figure.PieceColor == FigureColor.White && figure.Y == 7)
                        {
                            (figure as Pawn).Promote();
                        }
                        else if (figure.PieceColor == FigureColor.Black && figure.Y == 0)
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
    }
}
