using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chess
{
    internal class NonClickablePanel : Panel
    {
        public NonClickablePanel()
        {
            this.SetStyle(ControlStyles.Selectable, false);
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
    public class Cell
    {
        public const int SQUARE_SIZE = 64;
        public Panel Panel;
        public int X { get; private set; }
        public int Y { get; private set; }
        private Figure _Figure;

        public Cell(int x, int y)
        {
            this.X = x;
            this.Y = y;
            this.Panel = new NonClickablePanel();
            this.Panel.BackColor = Color.Transparent;
            this.Panel.Location = new Point(x * SQUARE_SIZE, y * SQUARE_SIZE);
            this.Panel.Size = new Size(SQUARE_SIZE, SQUARE_SIZE);
        }
        public Figure Figure
        {
            get
            {
                return _Figure;
            }
            set
            {
                _Figure = value;
                if (value != null)
                {
                    value.X = this.X;
                    value.Y = this.Y;
                    value.Sprite.Location = new Point(this.X * SQUARE_SIZE + ((SQUARE_SIZE - value.Sprite.Width) / 2), this.Y * SQUARE_SIZE + ((SQUARE_SIZE - value.Sprite.Height) / 2));
                    this.Panel.Parent.Controls.Add(value.Sprite);
                    value.Sprite.BringToFront();
                }
            }
        }
    }
}
