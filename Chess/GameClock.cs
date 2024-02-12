using System.Windows.Forms;

namespace Chess
{
    public partial class GameClock : UserControl
    {
        public GameClock()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.ResizeRedraw |
                               ControlStyles.OptimizedDoubleBuffer |
                                              ControlStyles.AllPaintingInWmPaint, true);
            this.nixieClockWhite.Start();
        }
        public void Press(Player player)
        {
            if (player.PickedColor == FigureColor.White)
            {
                this.nixieClockWhite.Stop();
                this.nixieClockBlack.Start();
            }
            else
            {
                this.nixieClockBlack.Stop();
                this.nixieClockWhite.Start();
            }
        }
    }
}
