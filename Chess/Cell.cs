using System.Drawing;
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
                    value.ImageLocation = this.Panel.Location;
                    value.Board = this.Panel.Parent as ChessBoard;
                }
            }
        }
    }
}
