using System.Windows.Forms;

namespace Chess
{
    public abstract class Figure
    {
        public int X { get; set; }
        public int Y { get; set; }
        public FigureColor Color { get; }
        public FigureType Name { get; }
        public bool HasMoved { get; set; }

        public PictureBox picture { get; set; }

        public Figure(FigureType figureType, FigureColor color, int x, int y)
        {
            this.Name = figureType;
            this.Color = color;
            this.X = x;
            this.Y = y;
            this.picture = new System.Windows.Forms.PictureBox();
            this.picture.Size = new System.Drawing.Size(60, 60);
            this.picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture.Cursor = System.Windows.Forms.Cursors.Hand;
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
