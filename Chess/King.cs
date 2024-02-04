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
        public King(FigureColor color, int x, int y) : base(FigureType.King, color, x, y)
        {
            if (color == FigureColor.White)
            {
                this.picture.Image = Image.FromFile("Chess_klt60.png");
            }
            else
            {
                this.picture.Image = Image.FromFile("Chess_kdt60.png");
            }
        }

        public override bool CanMove(int x, int y)
        {
            if (Math.Abs(this.X - x) <= 1 && Math.Abs(this.Y - y) <= 1)
            {
                return true;
            }
            return false;
        }
    }
}
