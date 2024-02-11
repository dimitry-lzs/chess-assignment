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
    public partial class EnPassantExplain : Form
    {
        public EnPassantExplain()
        {
            InitializeComponent();
            this.enPassantAnimation.Image = Image.FromFile("enPassant.gif");
            this.enPassantAnimation.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
        private void OpenLink(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.chess.com/terms/en-passant");
        }

        private void enPassantAnimation_Click(object sender, EventArgs e)
        {
            this.OpenLink(sender, null);
        }

        private void readMore_Click(object sender, EventArgs e)
        {
            this.OpenLink(sender, null);
        }
    }
}
