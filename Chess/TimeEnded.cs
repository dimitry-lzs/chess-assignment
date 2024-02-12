using System;
using System.Windows.Forms;

namespace Chess
{
    public partial class TimeEnded : Form
    {
        public TimeEnded(Player player)
        {
            InitializeComponent();
            this.lostPllayerName.Text = player.Name;
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
