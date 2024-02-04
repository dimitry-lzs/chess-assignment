
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    public class Bishop : Figure
    {
        public Bishop(FigureColor color, int x, int y) : base(FigureType.Bishop, color, x, y)
        {
            if (color == FigureColor.White)
            {
                this.picture.Image = System.Drawing.Image.FromFile("Chess_blt60.png");
            }
            else
            {
                this.picture.Image = System.Drawing.Image.FromFile("Chess_bdt60.png");
            }
        }

        public override bool CanMove(int x, int y)
        {
            if (Math.Abs(this.X - x) == Math.Abs(this.Y - y))
            {
                return true;
            }
            return false;
        }
    }
}
