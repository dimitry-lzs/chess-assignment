using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    public class Queen : Figure
    {
        public Queen(FigureColor color, int x, int y, ChessBoard chessboard) : base(FigureType.Queen, color, x, y)
        {
            if (color == FigureColor.White)
            {
                this.Sprite.Image = System.Drawing.Image.FromFile("Chess_qlt60.png");
            }
            else
            {
                this.Sprite.Image = System.Drawing.Image.FromFile("Chess_qdt60.png");
            }
        }

        public override bool CanMove(int x, int y)
        {
            if (this.X == x || this.Y == y || Math.Abs(this.X - x) == Math.Abs(this.Y - y))
            {
                return true;
            }
            return false;
        }
    }
}
