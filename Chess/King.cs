using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    public class King : Figure
    {
        public King(FigureColor color) : base(FigureType.King, color)
        {
            if (color == FigureColor.White)
            {
                this.Sprite = Image.FromFile("Chess_klt60.png");
            }
            else
            {
                this.Sprite = Image.FromFile("Chess_kdt60.png");
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
