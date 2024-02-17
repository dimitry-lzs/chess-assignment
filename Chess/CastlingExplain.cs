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
    public partial class CastlingExplain : Form
    {
        public CastlingExplain()
        {
            InitializeComponent();
            this.enPassantAnimation.Image = Properties.Resources.castlingAnimation;
            this.enPassantAnimation.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void enPassantAnimation_Click(object sender, EventArgs e)
        {
            this.OpenLink(sender, null);
        }
        private void OpenLink(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.chess.com/terms/castling-chess");
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void readMore_Click(object sender, EventArgs e)
        {
            this.OpenLink(sender, null);
        }
    }
}
