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
                this.knightPromotion.Image = Properties.Resources.Chess_nlt60;
                this.rookPromotion.Image = Properties.Resources.Chess_rlt60;
                this.queenPromotion.Image = Properties.Resources.Chess_qlt60;
            }
            else
            {
                this.knightPromotion.Image = Properties.Resources.Chess_ndt60;
                this.rookPromotion.Image = Properties.Resources.Chess_rdt60;
                this.queenPromotion.Image = Properties.Resources.Chess_qdt60;
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
