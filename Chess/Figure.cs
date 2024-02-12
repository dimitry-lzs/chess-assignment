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

        public void Move(int x, int y)
        {
            if (this.CanMove(x, y))
            {
                if (!this.HasMoved)
                {
                    this.HasMoved = true;
                }
                this.X = x;
                this.Y = y;
            }
        }
    }
}
