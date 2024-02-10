
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    public class Bishop : Figure
    {
        public Bishop(FigureColor color) : base(FigureType.Bishop, color)
        {
            if (color == FigureColor.White)
            {
                this.Sprite.Image = System.Drawing.Image.FromFile("Chess_blt60.png");
            }
            else
            {
                this.Sprite.Image = System.Drawing.Image.FromFile("Chess_bdt60.png");
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
