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
            this.SetStyle(
                System.Windows.Forms.ControlStyles.UserPaint |
                System.Windows.Forms.ControlStyles.AllPaintingInWmPaint |
                System.Windows.Forms.ControlStyles.OptimizedDoubleBuffer,
                true);
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
            this.GetCell('a', 8).Figure = new Rook(FigureColor.White);
            this.GetCell('b', 8).Figure = new Knight(FigureColor.White);
            this.GetCell('c', 8).Figure = new Bishop(FigureColor.White);
            this.GetCell('d', 8).Figure = new Queen(FigureColor.White);
            this.GetCell('e', 8).Figure = new King(FigureColor.White);
            this.GetCell('f', 8).Figure = new Bishop(FigureColor.White);
            this.GetCell('g', 8).Figure = new Knight(FigureColor.White);
            this.GetCell('h', 8).Figure = new Rook(FigureColor.White);
            this.GetCell('a', 7).Figure = new Pawn(FigureColor.White);
            this.GetCell('b', 7).Figure = new Pawn(FigureColor.White);
            this.GetCell('c', 7).Figure = new Pawn(FigureColor.White);
            this.GetCell('d', 7).Figure = new Pawn(FigureColor.White);
            this.GetCell('e', 7).Figure = new Pawn(FigureColor.White);
            this.GetCell('f', 7).Figure = new Pawn(FigureColor.White);
            this.GetCell('g', 7).Figure = new Pawn(FigureColor.White);
            this.GetCell('h', 7).Figure = new Pawn(FigureColor.White);
            this.GetCell('a', 2).Figure = new Pawn(FigureColor.Black);
            this.GetCell('b', 2).Figure = new Pawn(FigureColor.Black);
            this.GetCell('c', 2).Figure = new Pawn(FigureColor.Black);
            this.GetCell('d', 2).Figure = new Pawn(FigureColor.Black);
            this.GetCell('e', 2).Figure = new Pawn(FigureColor.Black);
            this.GetCell('f', 2).Figure = new Pawn(FigureColor.Black);
            this.GetCell('g', 2).Figure = new Pawn(FigureColor.Black);
            this.GetCell('h', 2).Figure = new Pawn(FigureColor.Black);
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
                Point point = new Point(e.X - this.SelectedFigure.Sprite.Width / 2, e.Y - this.SelectedFigure.Sprite.Height / 2);
                if (this.SelectedFigure.Sprite.Location != point)
                {
                    this.SelectedFigure.Sprite.Location = point;
                }
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
