using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    public class Knight : Figure
    {
        public Knight(FigureColor color) : base(FigureType.Knight, color)
        {
            if (color == FigureColor.White)
            {
                this.Sprite = System.Drawing.Image.FromFile("Chess_nlt60.png");
            }
            else
            {
                this.Sprite = System.Drawing.Image.FromFile("Chess_ndt60.png");
            }
        }

        public override bool CanMove(int x, int y)
        {
            if ((Math.Abs(this.X - x) == 2 && Math.Abs(this.Y - y) == 1) || (Math.Abs(this.X - x) == 1 && Math.Abs(this.Y - y) == 2))
            {
                return true;
            }
            return false;
        }
    }
}
