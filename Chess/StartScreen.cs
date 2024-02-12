using System;
using System.Drawing;
using System.Windows.Forms;

namespace Chess
{
    public partial class StartScreen : UserControl
    {
        public StartScreen()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.ResizeRedraw |
                          ControlStyles.OptimizedDoubleBuffer |
                          ControlStyles.AllPaintingInWmPaint, true);
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            SetupGame setupGame = new SetupGame();
            setupGame.Visible = false;

            this.Parent.Controls.Add(setupGame);

            this.Parent.ClientSize = new Size(800, 700);

            this.Parent.Controls.Remove(this);

            this.Dispose();

            setupGame.Visible = true;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void historyButton_Click(object sender, EventArgs e)
        {

        }

        private void StartScreen_Load(object sender, EventArgs e)
        {

        }
    }
}
