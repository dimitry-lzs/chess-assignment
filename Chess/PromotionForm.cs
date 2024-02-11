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
    public partial class PromotionForm : Form
    {
        public FigureType selectedPromotion;
        public PromotionForm(FigureColor figureColor)
        {
            InitializeComponent();
            this.knightPromotion.SizeMode = PictureBoxSizeMode.StretchImage;
            this.rookPromotion.SizeMode = PictureBoxSizeMode.StretchImage;
            this.queenPromotion.SizeMode = PictureBoxSizeMode.StretchImage;

            if (figureColor == FigureColor.White)
            {
                this.knightPromotion.Image = Image.FromFile("Chess_nlt60.png");
                this.rookPromotion.Image = Image.FromFile("Chess_rlt60.png");
                this.queenPromotion.Image = Image.FromFile("Chess_qlt60.png");
            }
            else
            {
                this.knightPromotion.Image = Image.FromFile("Chess_ndt60.png");
                this.rookPromotion.Image = Image.FromFile("Chess_rdt60.png");
                this.queenPromotion.Image = Image.FromFile("Chess_qdt60.png");
            }
        }

        private void queenPromotion_Click(object sender, EventArgs e)
        {
            this.selectedPromotion = FigureType.Queen;
            this.DialogResult = DialogResult.OK;
        }

        private void knightPromotion_Click(object sender, EventArgs e)
        {
            this.selectedPromotion = FigureType.Knight;
            this.DialogResult = DialogResult.OK;
        }

        private void rookPromotion_Click(object sender, EventArgs e)
        {
            this.selectedPromotion = FigureType.Rook;
            this.DialogResult = DialogResult.OK;
        }
    }
}
