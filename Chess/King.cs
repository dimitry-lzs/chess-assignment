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
            }
            return false;
        }
    }
}
