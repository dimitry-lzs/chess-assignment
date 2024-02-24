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
            GameWindow gameWindow = new GameWindow();
            gameWindow.ShowDialog();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void historyButton_Click(object sender, EventArgs e)
        {
            History history = new History();
            history.ShowDialog();
        }

        private void StartScreen_Load(object sender, EventArgs e)
        {

        }
    }
}
