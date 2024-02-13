using System;
using System.Drawing;
using System.Windows.Forms;

namespace Chess
{
    public class NonClickablePictureBox : PictureBox
    {
        public NonClickablePictureBox()
        {
            this.SetStyle(ControlStyles.Selectable, false);
            this.DoubleBuffered = true;
        }

        protected override void WndProc(ref Message m)
        {
            const int WM_NCHITTEST = 0x0084;
            const int HTTRANSPARENT = (-1);

            if (m.Msg == WM_NCHITTEST)
            {
                m.Result = (IntPtr)HTTRANSPARENT;
            }
            else
            {
                base.WndProc(ref m);
            }
        }
    }
    public abstract class Figure
    {
        public int X { get; set; }
        public int Y { get; set; }
        public FigureColor PieceColor { get; }
        public FigureType Name { get; }
        public bool HasMoved { get; set; }

        private Image _Sprite;
        public ChessBoard Board { get; set; }

        public Image Sprite
        {
            get
            {
                return this._Sprite;
            }
            set
            {
                this._Sprite = value;
                this.ImageLocation = new Point(this.X * Cell.SQUARE_SIZE, this.Y * Cell.SQUARE_SIZE);
            }
        }
        public Point ImageLocation;

        public Figure(FigureType figureType, FigureColor color)
        {
            this.Name = figureType;
            this.PieceColor = color;
            this.HasMoved = false;
        }

        public abstract bool CanMove(int x, int y);

        protected bool StraightPathIsClear(int x, int y)
        {
            if (this.X == x)
            {
                int yDirection = Math.Sign(y - this.Y);
                int currentY = this.Y + yDirection;
                while (currentY != y)
                {
                    if (this.Board.GetFigure(x, currentY) != null)
                    {
                        return false;
                    }
                    currentY += yDirection;
                }
            }
            else if (this.Y == y)
            {
                int xDirection = Math.Sign(x - this.X);
                int currentX = this.X + xDirection;
                while (currentX != x)
                {
                    if (this.Board.GetFigure(currentX, y) != null)
                    {
                        return false;
                    }
                    currentX += xDirection;
                }
            }
            return true;
        }
        protected bool DiagonalPathIsClear(int x, int y)
        {
            int xDirection = Math.Sign(x - this.X);
            int yDirection = Math.Sign(y - this.Y);
            int currentX = this.X + xDirection;
            int currentY = this.Y + yDirection;
            while (currentX != x && currentY != y)
            {
                if (this.Board.GetFigure(currentX, currentY) != null)
                {
                    return false;
                }
                currentX += xDirection;
                currentY += yDirection;
            }
            return true;
        }
    }
}
