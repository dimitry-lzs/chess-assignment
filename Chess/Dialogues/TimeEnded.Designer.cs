namespace Chess
{
    partial class TimeEnded
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TimeEnded));
            this.lostPlayerName = new System.Windows.Forms.Label();
            this.article = new System.Windows.Forms.Label();
            this.PlayAgain = new System.Windows.Forms.Label();
            this.MainMenu = new System.Windows.Forms.Label();
            this.Exit = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lostPlayerName
            // 
            this.lostPlayerName.AutoSize = true;
            this.lostPlayerName.BackColor = System.Drawing.Color.Transparent;
            this.lostPlayerName.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lostPlayerName.ForeColor = System.Drawing.Color.Moccasin;
            this.lostPlayerName.Location = new System.Drawing.Point(152, 58);
            this.lostPlayerName.Name = "lostPlayerName";
            this.lostPlayerName.Size = new System.Drawing.Size(265, 29);
            this.lostPlayerName.TabIndex = 6;
            this.lostPlayerName.Text = "Player White Lost by time";
            // 
            // article
            // 
            this.article.AutoSize = true;
            this.article.BackColor = System.Drawing.Color.Transparent;
            this.article.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.article.ForeColor = System.Drawing.Color.Moccasin;
            this.article.Location = new System.Drawing.Point(100, 126);
            this.article.Name = "article";
            this.article.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.article.Size = new System.Drawing.Size(360, 161);
            this.article.TabIndex = 7;
            this.article.Text = "Time\'s up! The sands of the timer have run out,\r\nmarking the end of the game. \r\nD" +
    "espite a valiant effort, you\'ve lost by timeout.\r\nRemember, every second counts." +
    "\r\nBetter luck next time!\r\n\r\n\r\n";
            this.article.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PlayAgain
            // 
            this.PlayAgain.AutoSize = true;
            this.PlayAgain.BackColor = System.Drawing.Color.Transparent;
            this.PlayAgain.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PlayAgain.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayAgain.ForeColor = System.Drawing.Color.Moccasin;
            this.PlayAgain.Location = new System.Drawing.Point(374, 354);
            this.PlayAgain.Name = "PlayAgain";
            this.PlayAgain.Size = new System.Drawing.Size(86, 23);
            this.PlayAgain.TabIndex = 8;
            this.PlayAgain.Text = "Play Again";
            // 
            // MainMenu
            // 
            this.MainMenu.AutoSize = true;
            this.MainMenu.BackColor = System.Drawing.Color.Transparent;
            this.MainMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MainMenu.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenu.ForeColor = System.Drawing.Color.Moccasin;
            this.MainMenu.Location = new System.Drawing.Point(223, 354);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(90, 23);
            this.MainMenu.TabIndex = 9;
            this.MainMenu.Text = "Main Menu";
            // 
            // Exit
            // 
            this.Exit.AutoSize = true;
            this.Exit.BackColor = System.Drawing.Color.Transparent;
            this.Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Exit.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.ForeColor = System.Drawing.Color.Moccasin;
            this.Exit.Location = new System.Drawing.Point(100, 354);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(41, 23);
            this.Exit.TabIndex = 10;
            this.Exit.Text = "Exit";
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // TimeEnded
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Chess.Properties.Resources.timeExpiredBackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(550, 409);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.MainMenu);
            this.Controls.Add(this.PlayAgain);
            this.Controls.Add(this.article);
            this.Controls.Add(this.lostPlayerName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(566, 448);
            this.MinimumSize = new System.Drawing.Size(566, 448);
            this.Name = "TimeEnded";
            this.Text = "TimeEnded";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label article;
        private System.Windows.Forms.Label PlayAgain;
        private System.Windows.Forms.Label MainMenu;
        private System.Windows.Forms.Label Exit;
        public System.Windows.Forms.Label lostPlayerName;
    }
}