using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chess
{
    public partial class Bin : UserControl
    {
        int Items = 0;

        public Bin()
        {
            InitializeComponent();
        }

        private void Bin_Load(object sender, EventArgs e)
        {
        }
        public void discardFigure(Figure figure)
        {
            Panel panel = new Panel();
            panel.Size = new Size(32, 32);
            panel.Location = new Point(this.Items % 2 == 0 ? 0 : 32, (this.Items / 2) * 32);
            this.Height = (this.Items / 2 + 1) * 32;
            panel.BackgroundImageLayout = ImageLayout.Stretch;
            panel.BackgroundImage = figure.Sprite;
            this.Controls.Add(panel);
            this.Items++;
        }
    }
}
