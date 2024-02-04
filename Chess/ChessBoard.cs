using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chess
{
    public partial class ChessBoard : UserControl
    {
        private const int BOARD_SIZE = 8;
        private Cell[,] board = new Cell[BOARD_SIZE, BOARD_SIZE];

        public ChessBoard()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
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
            this.board[0, 0].Figure = new Rook(FigureColor.White, 0, 0);
            this.board[1, 0].Figure = new Knight(FigureColor.White, 1, 0);
            this.board[2, 0].Figure = new Bishop(FigureColor.White, 2, 0);
            this.board[3, 0].Figure = new Queen(FigureColor.White, 3, 0);
            this.board[4, 0].Figure = new King(FigureColor.White, 4, 0);
            this.board[5, 0].Figure = new Bishop(FigureColor.White, 5, 0);
            this.board[6, 0].Figure = new Knight(FigureColor.White, 6, 0);
            this.board[7, 0].Figure = new Rook(FigureColor.White, 7, 0);
            this.board[0, 1].Figure = new Pawn(FigureColor.White, 0, 1);
            this.board[1, 1].Figure = new Pawn(FigureColor.White, 1, 1);
            this.board[2, 1].Figure = new Pawn(FigureColor.White, 2, 1);
            this.board[3, 1].Figure = new Pawn(FigureColor.White, 3, 1);
            this.board[4, 1].Figure = new Pawn(FigureColor.White, 4, 1);
            this.board[5, 1].Figure = new Pawn(FigureColor.White, 5, 1);
            this.board[6, 1].Figure = new Pawn(FigureColor.White, 6, 1);
            this.board[7, 1].Figure = new Pawn(FigureColor.White, 7, 1);
            this.board[0, 6].Figure = new Pawn(FigureColor.Black, 0, 6);
            this.board[1, 6].Figure = new Pawn(FigureColor.Black, 1, 6);
            this.board[2, 6].Figure = new Pawn(FigureColor.Black, 2, 6);
            this.board[3, 6].Figure = new Pawn(FigureColor.Black, 3, 6);
            this.board[4, 6].Figure = new Pawn(FigureColor.Black, 4, 6);
            this.board[5, 6].Figure = new Pawn(FigureColor.Black, 5, 6);
            this.board[6, 6].Figure = new Pawn(FigureColor.Black, 6, 6);
            this.board[7, 6].Figure = new Pawn(FigureColor.Black, 7, 6);
            this.board[0, 7].Figure = new Rook(FigureColor.Black, 0, 7);
            this.board[1, 7].Figure = new Knight(FigureColor.Black, 1, 7);
            this.board[2, 7].Figure = new Bishop(FigureColor.Black, 2, 7);
            this.board[3, 7].Figure = new Queen(FigureColor.Black, 3, 7);
            this.board[4, 7].Figure = new King(FigureColor.Black, 4, 7);
            this.board[5, 7].Figure = new Bishop(FigureColor.Black, 5, 7);
            this.board[6, 7].Figure = new Knight(FigureColor.Black, 6, 7);
            this.board[7, 7].Figure = new Rook(FigureColor.Black, 7, 7);
        }

        private void ChessBoard_Load(object sender, EventArgs e)
        {
            this.Size = new Size(BOARD_SIZE * Cell.SQUARE_SIZE, BOARD_SIZE * Cell.SQUARE_SIZE);
            this.Location = new Point(30, 100);
            this.InitBoard();
        }
        public Figure GetFigure(int x, int y)
        {
            return this.board[x, y].Figure;
        }   
    }
}
