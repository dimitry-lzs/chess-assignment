using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    public class Pawn : Figure
    {
        public Pawn(FigureColor color) : base(FigureType.Pawn, color)
        {
            if (color == FigureColor.White)
            {
                this.Sprite = System.Drawing.Image.FromFile("Chess_plt60.png");
            }
            else
            {
                this.Sprite = System.Drawing.Image.FromFile("Chess_pdt60.png");
            }
        }

        public override bool CanMove(int x, int y)
        {
            if (this.PieceColor == FigureColor.White)
            {
                if (this.Y == 1)
                {
                    if (this.X == x && (y == 2 || y == 3))
                    {
                        return true;
                    }
                }
                if (this.X == x && y == this.Y + 1)
                {
                    return true;
                }
                if (Math.Abs(this.X - x) == 1 && y == this.Y + 1)
                {
                    return true;
                }
            }
            else
            {
                if (this.Y == 6)
                {
                    if (this.X == x && (y == 5 || y == 4))
                    {
                        return true;
                    }
                }
                if (this.X == x && y == this.Y - 1)
                {
                    return true;
                }
                if (Math.Abs(this.X - x) == 1 && y == this.Y - 1)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
