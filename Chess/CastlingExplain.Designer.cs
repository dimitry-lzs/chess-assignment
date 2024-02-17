namespace Chess
{
    partial class CastlingExplain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CastlingExplain));
            this.title = new System.Windows.Forms.Label();
            this.article = new System.Windows.Forms.Label();
            this.subTitle = new System.Windows.Forms.Label();
            this.enPassantAnimation = new System.Windows.Forms.PictureBox();
            this.readMore = new System.Windows.Forms.Label();
            this.okButton = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.enPassantAnimation)).BeginInit();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.BackColor = System.Drawing.Color.Transparent;
            this.title.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.Moccasin;
            this.title.Location = new System.Drawing.Point(12, 28);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(608, 45);
            this.title.TabIndex = 1;
            this.title.Text = "Did you find the last move interesting?";
            // 
            // article
            // 
            this.article.AutoSize = true;
            this.article.BackColor = System.Drawing.Color.Transparent;
            this.article.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.article.ForeColor = System.Drawing.Color.Moccasin;
            this.article.Location = new System.Drawing.Point(17, 188);
            this.article.Name = "article";
            this.article.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.article.Size = new System.Drawing.Size(288, 187);
            this.article.TabIndex = 3;
            this.article.Text = resources.GetString("article.Text");
            this.article.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // subTitle
            // 
            this.subTitle.AutoSize = true;
            this.subTitle.BackColor = System.Drawing.Color.Transparent;
            this.subTitle.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subTitle.ForeColor = System.Drawing.Color.Moccasin;
            this.subTitle.Location = new System.Drawing.Point(15, 138);
            this.subTitle.Name = "subTitle";
            this.subTitle.Size = new System.Drawing.Size(79, 26);
            this.subTitle.TabIndex = 4;
            this.subTitle.Text = "Castling";
            // 
            // enPassantAnimation
            // 
            this.enPassantAnimation.BackColor = System.Drawing.Color.Transparent;
            this.enPassantAnimation.BackgroundImage = global::Chess.Properties.Resources.castlingAnimation;
            this.enPassantAnimation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.enPassantAnimation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.enPassantAnimation.Location = new System.Drawing.Point(335, 263);
            this.enPassantAnimation.Name = "enPassantAnimation";
            this.enPassantAnimation.Size = new System.Drawing.Size(280, 112);
            this.enPassantAnimation.TabIndex = 5;
            this.enPassantAnimation.TabStop = false;
            this.enPassantAnimation.Click += new System.EventHandler(this.enPassantAnimation_Click);
            // 
            // readMore
            // 
            this.readMore.AutoSize = true;
            this.readMore.BackColor = System.Drawing.Color.Transparent;
            this.readMore.Cursor = System.Windows.Forms.Cursors.Hand;
            this.readMore.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.readMore.ForeColor = System.Drawing.Color.Moccasin;
            this.readMore.Location = new System.Drawing.Point(16, 416);
            this.readMore.Name = "readMore";
            this.readMore.Size = new System.Drawing.Size(98, 23);
            this.readMore.TabIndex = 6;
            this.readMore.Text = "Read more...";
            this.readMore.Click += new System.EventHandler(this.readMore_Click);
            // 
            // okButton
            // 
            this.okButton.AutoSize = true;
            this.okButton.BackColor = System.Drawing.Color.Transparent;
            this.okButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.okButton.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.okButton.ForeColor = System.Drawing.Color.Moccasin;
            this.okButton.Location = new System.Drawing.Point(252, 416);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(53, 23);
            this.okButton.TabIndex = 7;
            this.okButton.Text = "Got it";
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // CastlingExplain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Chess.Properties.Resources.castlingBackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(627, 462);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.readMore);
            this.Controls.Add(this.enPassantAnimation);
            this.Controls.Add(this.subTitle);
            this.Controls.Add(this.article);
            this.Controls.Add(this.title);
            this.Name = "CastlingExplain";
            this.Text = "CastlingExplain";
            ((System.ComponentModel.ISupportInitialize)(this.enPassantAnimation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label article;
        private System.Windows.Forms.Label subTitle;
        private System.Windows.Forms.PictureBox enPassantAnimation;
        private System.Windows.Forms.Label readMore;
        private System.Windows.Forms.Label okButton;
    }
}