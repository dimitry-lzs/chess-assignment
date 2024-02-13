using System;

namespace Chess
{
    public class King : Figure
    {
        public King(FigureColor color) : base(FigureType.King, color)
        {
            if (color == FigureColor.White)
            {
                this.Sprite = Properties.Resources.Chess_klt60;
            }
            else
            {
                this.Sprite = Properties.Resources.Chess_kdt60;
            }
        }

        public override bool CanMove(int x, int y)
        {
            Figure targetCellFigure = this.Board.GetFigure(x, y);
            if (targetCellFigure == null || targetCellFigure.PieceColor != this.PieceColor)
            {
                if (Math.Abs(this.X - x) <= 1 && Math.Abs(this.Y - y) <= 1)
                {
                    return true;
                }
                if (Castle(x, y))
                {
                    return true;
                }
            }
            return false;
        }

        private bool Castle(int x, int y)
        {
            if (this.HasMoved == false)
            {
                if (this.PieceColor == FigureColor.White)
                {
                    if (x == 6 && y == 7)
                    {
                        Figure rook = this.Board.GetFigure(x + 1, y);
                        if (rook != null && rook.HasMoved == false)
                        {
                            if (this.Board.GetFigure(x - 1, y) == null && this.Board.GetFigure(x, y) == null)
                            {
                                this.Board.PerformCastling(rook, x - 1, y);
                                return true;
                            }
                        }
                    }
                    if (x == 2 && y == 7)
                    {
                        Figure rook = this.Board.GetFigure(x - 2, y);
                        if (rook != null && rook.HasMoved == false)
                        {
                            if (this.Board.GetFigure(x - 1, y) == null && this.Board.GetFigure(x, y) == null && this.Board.GetFigure(x + 1, y) == null)
                            {
                                this.Board.PerformCastling(rook, x + 1, y);
                                return true;
                            }
                        }
                    }
                }
                else if (this.PieceColor == FigureColor.Black)
                {
                    if (x == 6 && y == 0)
                    {
                        Figure rook = this.Board.GetFigure(x + 1, y);
                        if (rook != null && rook.HasMoved == false)
                        {
                            if (this.Board.GetFigure(x - 1, y) == null && this.Board.GetFigure(x, y) == null)
                            {
                                this.Board.PerformCastling(rook, x - 1, y);
                                return true;
                            }
                        }
                    }
                    if (x == 2 && y == 0)
                    {
                        Figure rook = this.Board.GetFigure(x - 2, y);
                        if (rook != null && rook.HasMoved == false)
                        {
                            if (this.Board.GetFigure(x - 1, y) == null && this.Board.GetFigure(x, y) == null && this.Board.GetFigure(x + 1, y) == null)
                            {
                                this.Board.PerformCastling(rook, x + 1, y);
                                return true;
                            }
                        }
                    }
                }
            }
            return false;
        }
    }
}
