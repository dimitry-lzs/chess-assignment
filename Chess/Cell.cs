using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chess
{
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
            this.Panel = new Panel();
            Panel.BackColor = (x + y) % 2 == 0 ? Color.Moccasin : Color.FromArgb(101, 67, 33);
            Panel.Location = new Point(x * SQUARE_SIZE, y * SQUARE_SIZE);
            Panel.Size = new Size(SQUARE_SIZE, SQUARE_SIZE);
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
                    Panel.Controls.Add(value.picture);
                }
            }
        }   
    }
}
