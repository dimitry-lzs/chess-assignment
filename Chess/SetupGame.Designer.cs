namespace Chess
{
    partial class SetupGame
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.playerWhite = new System.Windows.Forms.Label();
            this.playerBlack = new System.Windows.Forms.Label();
            this.whitePlayerName = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.beginGame = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // playerWhite
            // 
            this.playerWhite.AutoSize = true;
            this.playerWhite.BackColor = System.Drawing.Color.Transparent;
            this.playerWhite.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.playerWhite.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerWhite.ForeColor = System.Drawing.Color.Moccasin;
            this.playerWhite.Location = new System.Drawing.Point(23, 53);
            this.playerWhite.Name = "playerWhite";
            this.playerWhite.Size = new System.Drawing.Size(222, 45);
            this.playerWhite.TabIndex = 6;
            this.playerWhite.Text = "Player White";
            this.playerWhite.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // playerBlack
            // 
            this.playerBlack.AutoSize = true;
            this.playerBlack.BackColor = System.Drawing.Color.Transparent;
            this.playerBlack.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.playerBlack.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerBlack.ForeColor = System.Drawing.Color.Moccasin;
            this.playerBlack.Location = new System.Drawing.Point(375, 53);
            this.playerBlack.Name = "playerBlack";
            this.playerBlack.Size = new System.Drawing.Size(209, 45);
            this.playerBlack.TabIndex = 7;
            this.playerBlack.Text = "Player Black";
            this.playerBlack.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // whitePlayerName
            // 
            this.whitePlayerName.BackColor = System.Drawing.Color.SaddleBrown;
            this.whitePlayerName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.whitePlayerName.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.whitePlayerName.ForeColor = System.Drawing.Color.Moccasin;
            this.whitePlayerName.Location = new System.Drawing.Point(31, 171);
            this.whitePlayerName.Name = "whitePlayerName";
            this.whitePlayerName.Size = new System.Drawing.Size(214, 27);
            this.whitePlayerName.TabIndex = 8;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.SaddleBrown;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.Moccasin;
            this.textBox1.Location = new System.Drawing.Point(383, 171);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(201, 27);
            this.textBox1.TabIndex = 9;
            // 
            // beginGame
            // 
            this.beginGame.AutoSize = true;
            this.beginGame.BackColor = System.Drawing.Color.Transparent;
            this.beginGame.Cursor = System.Windows.Forms.Cursors.Hand;
            this.beginGame.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.beginGame.ForeColor = System.Drawing.Color.Moccasin;
            this.beginGame.Location = new System.Drawing.Point(247, 277);
            this.beginGame.Name = "beginGame";
            this.beginGame.Size = new System.Drawing.Size(118, 27);
            this.beginGame.TabIndex = 10;
            this.beginGame.Text = "Begin Game";
            this.beginGame.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.beginGame.Click += new System.EventHandler(this.beginGame_Click);
            // 
            // SetupGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.beginGame);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.whitePlayerName);
            this.Controls.Add(this.playerBlack);
            this.Controls.Add(this.playerWhite);
            this.Name = "SetupGame";
            this.Size = new System.Drawing.Size(610, 383);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label playerWhite;
        private System.Windows.Forms.Label playerBlack;
        private System.Windows.Forms.TextBox whitePlayerName;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label beginGame;
    }
}
