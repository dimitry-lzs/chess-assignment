using System;
using System.Windows.Forms;

namespace Chess
{
    public partial class SetupGame : UserControl
    {

        public SetupGame()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.ResizeRedraw |
                          ControlStyles.OptimizedDoubleBuffer |
                          ControlStyles.AllPaintingInWmPaint, true);
        }

        private void beginGame_Click(object sender, EventArgs e)
        {
            Player whitesPlayer = new Player(this.whitePlayerName.Text, FigureColor.White);
            Player blacksPlayer = new Player(this.blackPlayerName.Text, FigureColor.Black);
            GameScreen gameScreen = new GameScreen(whitesPlayer, blacksPlayer);
            this.Parent.ClientSize = gameScreen.Size;
            this.Parent.Controls.Add(gameScreen);
            this.Parent.Controls.Remove(this);
        }
    }
}
