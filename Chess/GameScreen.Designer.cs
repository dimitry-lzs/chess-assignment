namespace Chess
{
    partial class GameScreen
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
            this.blackPlayerName = new System.Windows.Forms.Label();
            this.whitePlayerName = new System.Windows.Forms.Label();
            this.framedChessboard = new Chess.FramedChessboard();
            this.gameClock = new Chess.GameClock();
            this.blackPlayerBin = new Chess.Bin();
            this.whitePlayerBin = new Chess.Bin();
            this.SuspendLayout();
            // 
            // blackPlayerName
            // 
            this.blackPlayerName.AutoSize = true;
            this.blackPlayerName.BackColor = System.Drawing.Color.Transparent;
            this.blackPlayerName.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blackPlayerName.ForeColor = System.Drawing.Color.Moccasin;
            this.blackPlayerName.Location = new System.Drawing.Point(823, 100);
            this.blackPlayerName.Name = "blackPlayerName";
            this.blackPlayerName.Size = new System.Drawing.Size(132, 29);
            this.blackPlayerName.TabIndex = 4;
            this.blackPlayerName.Text = "Player Black";
            // 
            // whitePlayerName
            // 
            this.whitePlayerName.AutoSize = true;
            this.whitePlayerName.BackColor = System.Drawing.Color.Transparent;
            this.whitePlayerName.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.whitePlayerName.ForeColor = System.Drawing.Color.Moccasin;
            this.whitePlayerName.Location = new System.Drawing.Point(35, 100);
            this.whitePlayerName.Name = "whitePlayerName";
            this.whitePlayerName.Size = new System.Drawing.Size(138, 29);
            this.whitePlayerName.TabIndex = 5;
            this.whitePlayerName.Text = "Player White";
            // 
            // framedChessboard
            // 
            this.framedChessboard.Location = new System.Drawing.Point(224, 100);
            this.framedChessboard.Name = "framedChessboard";
            this.framedChessboard.Size = new System.Drawing.Size(552, 552);
            this.framedChessboard.TabIndex = 7;
            // 
            // gameClock
            // 
            this.gameClock.BackColor = System.Drawing.Color.Transparent;
            this.gameClock.Location = new System.Drawing.Point(224, 25);
            this.gameClock.Margin = new System.Windows.Forms.Padding(0);
            this.gameClock.Name = "gameClock";
            this.gameClock.Size = new System.Drawing.Size(552, 75);
            this.gameClock.TabIndex = 6;
            // 
            // blackPlayerBin
            // 
            this.blackPlayerBin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(87)))), ((int)(((byte)(51)))));
            this.blackPlayerBin.Location = new System.Drawing.Point(828, 184);
            this.blackPlayerBin.Margin = new System.Windows.Forms.Padding(0);
            this.blackPlayerBin.Name = "blackPlayerBin";
            this.blackPlayerBin.Size = new System.Drawing.Size(64, 0);
            this.blackPlayerBin.TabIndex = 10;
            // 
            // whitePlayerBin
            // 
            this.whitePlayerBin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(87)))), ((int)(((byte)(51)))));
            this.whitePlayerBin.Location = new System.Drawing.Point(109, 184);
            this.whitePlayerBin.Margin = new System.Windows.Forms.Padding(0);
            this.whitePlayerBin.Name = "whitePlayerBin";
            this.whitePlayerBin.Size = new System.Drawing.Size(64, 0);
            this.whitePlayerBin.TabIndex = 11;
            // 
            // GameScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Chess.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.whitePlayerBin);
            this.Controls.Add(this.blackPlayerBin);
            this.Controls.Add(this.framedChessboard);
            this.Controls.Add(this.gameClock);
            this.Controls.Add(this.whitePlayerName);
            this.Controls.Add(this.blackPlayerName);
            this.Name = "GameScreen";
            this.Size = new System.Drawing.Size(984, 711);
            this.Load += new System.EventHandler(this.GameScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label blackPlayerName;
        private System.Windows.Forms.Label whitePlayerName;
        private GameClock gameClock;
        private FramedChessboard framedChessboard;
        private Bin blackPlayerBin;
        private Bin whitePlayerBin;
    }
}