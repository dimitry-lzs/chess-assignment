using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    public class Rook : Figure
    {
        public Rook(FigureColor color, int x, int y) : base(FigureType.Rook, color, x, y)
        {
            if (color == FigureColor.White)
            {
                this.picture.Image = System.Drawing.Image.FromFile("Chess_rlt60.png");
            }
            else
            {
                this.picture.Image = System.Drawing.Image.FromFile("Chess_rdt60.png");
            }
        }

        public override bool CanMove(int x, int y)
        {
            if (this.X == x || this.Y == y)
            {
                return true;
            }
            return false;
        }
    }

}
