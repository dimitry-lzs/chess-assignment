namespace Chess
{
    partial class PromotionForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.promotionLabel = new System.Windows.Forms.Label();
            this.knightPromotion = new System.Windows.Forms.PictureBox();
            this.queenPromotion = new System.Windows.Forms.PictureBox();
            this.rookPromotion = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.knightPromotion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.queenPromotion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rookPromotion)).BeginInit();
            this.SuspendLayout();
            // 
            // promotionLabel
            // 
            this.promotionLabel.AutoSize = true;
            this.promotionLabel.BackColor = System.Drawing.Color.Transparent;
            this.promotionLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.promotionLabel.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.promotionLabel.ForeColor = System.Drawing.Color.Moccasin;
            this.promotionLabel.Location = new System.Drawing.Point(174, 21);
            this.promotionLabel.Name = "promotionLabel";
            this.promotionLabel.Size = new System.Drawing.Size(251, 45);
            this.promotionLabel.TabIndex = 0;
            this.promotionLabel.Text = "Pawn promotion";
            // 
            // knightPromotion
            // 
            this.knightPromotion.BackColor = System.Drawing.Color.Transparent;
            this.knightPromotion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.knightPromotion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.knightPromotion.Location = new System.Drawing.Point(100, 110);
            this.knightPromotion.Name = "knightPromotion";
            this.knightPromotion.Size = new System.Drawing.Size(80, 80);
            this.knightPromotion.TabIndex = 1;
            this.knightPromotion.TabStop = false;
            this.knightPromotion.Click += new System.EventHandler(this.knightPromotion_Click);
            // 
            // queenPromotion
            // 
            this.queenPromotion.BackColor = System.Drawing.Color.Transparent;
            this.queenPromotion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.queenPromotion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.queenPromotion.Location = new System.Drawing.Point(260, 110);
            this.queenPromotion.Name = "queenPromotion";
            this.queenPromotion.Size = new System.Drawing.Size(80, 80);
            this.queenPromotion.TabIndex = 2;
            this.queenPromotion.TabStop = false;
            this.queenPromotion.Click += new System.EventHandler(this.queenPromotion_Click);
            // 
            // rookPromotion
            // 
            this.rookPromotion.BackColor = System.Drawing.Color.Transparent;
            this.rookPromotion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.rookPromotion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rookPromotion.Location = new System.Drawing.Point(420, 110);
            this.rookPromotion.Name = "rookPromotion";
            this.rookPromotion.Size = new System.Drawing.Size(80, 80);
            this.rookPromotion.TabIndex = 3;
            this.rookPromotion.TabStop = false;
            this.rookPromotion.Click += new System.EventHandler(this.rookPromotion_Click);
            // 
            // PromotionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Chess.Properties.Resources.promotionBackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(584, 286);
            this.Controls.Add(this.rookPromotion);
            this.Controls.Add(this.queenPromotion);
            this.Controls.Add(this.knightPromotion);
            this.Controls.Add(this.promotionLabel);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "PromotionForm";
            this.Text = "PromotionForm";
            ((System.ComponentModel.ISupportInitialize)(this.knightPromotion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.queenPromotion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rookPromotion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label promotionLabel;
        private System.Windows.Forms.PictureBox knightPromotion;
        private System.Windows.Forms.PictureBox queenPromotion;
        private System.Windows.Forms.PictureBox rookPromotion;
    }
}