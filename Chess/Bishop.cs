
using System;

namespace Chess
{
    public class Bishop : Figure
    {
        public Bishop(FigureColor color) : base(FigureType.Bishop, color)
        {
            if (color == FigureColor.White)
            {
                this.Sprite = Properties.Resources.Chess_blt60;
            }
            else
            {
                this.Sprite = Properties.Resources.Chess_bdt60;
            }
        }

        public override bool CanMove(int x, int y)
        {
            Figure targetCellFigure = this.Board.GetFigure(x, y);

            if (targetCellFigure == null || targetCellFigure.PieceColor != this.PieceColor)
            {
                if (Math.Abs(this.X - x) == Math.Abs(this.Y - y))
                {
                    if (this.DiagonalPathIsClear(x, y))
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
