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

namespace Chess
{
    public partial class ChessBoard : UserControl
    {
        private const int BOARD_SIZE = 8;
        private Cell[,] board = new Cell[BOARD_SIZE, BOARD_SIZE];
        private Figure _SelectedFigure;

        public Figure SelectedFigure {
            get { return _SelectedFigure; }
            set {
                if (value != null) value.Sprite.BringToFront();
                this._SelectedFigure = value;
            }
        }

        public ChessBoard()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.DoubleBuffer, true);
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.SetStyle(ControlStyles.UserPaint, true);
            this.UpdateStyles();
            this.FillGrid();
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

        private void InitBoard()
        {
            /*
            this.board[0, 0].Figure = new Rook(FigureColor.White, 0, 0, this);
            this.board[1, 0].Figure = new Knight(FigureColor.White, 1, 0, this);
            this.board[2, 0].Figure = new Bishop(FigureColor.White, 2, 0, this);
            this.board[3, 0].Figure = new Queen(FigureColor.White, 3, 0, this);
            this.board[4, 0].Figure = new King(FigureColor.White, 4, 0, this);
            this.board[5, 0].Figure = new Bishop(FigureColor.White, 5, 0, this);
            this.board[6, 0].Figure = new Knight(FigureColor.White, 6, 0, this);
            this.board[7, 0].Figure = new Rook(FigureColor.White, 7, 0, this);
            this.board[0, 1].Figure = new Pawn(FigureColor.White, 0, 1, this);
            this.board[1, 1].Figure = new Pawn(FigureColor.White, 1, 1, this);
            this.board[2, 1].Figure = new Pawn(FigureColor.White, 2, 1, this);
            this.board[3, 1].Figure = new Pawn(FigureColor.White, 3, 1, this);
            this.board[4, 1].Figure = new Pawn(FigureColor.White, 4, 1, this);
            this.board[5, 1].Figure = new Pawn(FigureColor.White, 5, 1, this);
            this.board[6, 1].Figure = new Pawn(FigureColor.White, 6, 1, this);
            this.board[7, 1].Figure = new Pawn(FigureColor.White, 7, 1, this);
            this.board[0, 6].Figure = new Pawn(FigureColor.Black, 0, 6, this);
            this.board[1, 6].Figure = new Pawn(FigureColor.Black, 1, 6, this);
            this.board[2, 6].Figure = new Pawn(FigureColor.Black, 2, 6, this);
            this.board[3, 6].Figure = new Pawn(FigureColor.Black, 3, 6, this);
            this.board[4, 6].Figure = new Pawn(FigureColor.Black, 4, 6, this);
            this.board[5, 6].Figure = new Pawn(FigureColor.Black, 5, 6, this);
            this.board[6, 6].Figure = new Pawn(FigureColor.Black, 6, 6, this);
            this.board[7, 6].Figure = new Pawn(FigureColor.Black, 7, 6, this);
            this.board[0, 7].Figure = new Rook(FigureColor.Black, 0, 7, this);
            this.board[1, 7].Figure = new Knight(FigureColor.Black, 1, 7, this);
            this.board[2, 7].Figure = new Bishop(FigureColor.Black, 2, 7, this);
            this.board[3, 7].Figure = new Queen(FigureColor.Black, 3, 7, this);
            this.board[4, 7].Figure = new King(FigureColor.Black, 4, 7, this);
            this.board[5, 7].Figure = new Bishop(FigureColor.Black, 5, 7, this);
            this.board[6, 7].Figure = new Knight(FigureColor.Black, 6, 7, this);
            this.board[7, 7].Figure = new Rook(FigureColor.Black, 7, 7, this);
            */
            this.GetCell('a', 1).Figure = new Rook(FigureColor.Black, 0, 7, this);
        }

        private void ChessBoard_Load(object sender, EventArgs e)
        {
            this.Size = new Size(BOARD_SIZE * Cell.SQUARE_SIZE, BOARD_SIZE * Cell.SQUARE_SIZE);
            this.Location = new Point(30, 100);
            this.InitBoard();
            this.BackgroundImage = Image.FromFile("Board.png");
            this.BackgroundImageLayout = ImageLayout.Stretch;
            this.MouseMove += ChessBoard_MouseMove;
            this.MouseDown += ChessBoard_MouseDown;
            this.MouseUp += ChessBoard_MouseUp;
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
        private void ChessBoard_MouseDown(object sender, MouseEventArgs e)
        {
            this.SelectedFigure = this.GetFigure(e.X / Cell.SQUARE_SIZE, e.Y / Cell.SQUARE_SIZE);
        }
        private void ChessBoard_MouseMove(object sender, MouseEventArgs e)
        {
            if (this.SelectedFigure != null)
            {
                this.Controls.SetChildIndex(this.SelectedFigure.Sprite, 0);
                this.SelectedFigure.Sprite.Location = new Point(e.X - this.SelectedFigure.Sprite.Width / 2, e.Y - this.SelectedFigure.Sprite.Height / 2);
            }
        }
        private void ChessBoard_MouseUp(object sender, MouseEventArgs e)
        {
            if (this.SelectedFigure != null)
            {
                this.PlaceFigure(this.SelectedFigure, e.X, e.Y);
                this.SelectedFigure = null;
            }
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
                }
                else
                {
                    this.board[figure.X, figure.Y].Figure = figure;
                }
            }
        }
    }
}
