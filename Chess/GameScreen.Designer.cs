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
            this.whiteWinButton = new System.Windows.Forms.Label();
            this.whiteResignButton = new System.Windows.Forms.Label();
            this.drawButton = new System.Windows.Forms.Label();
            this.blackResignButton = new System.Windows.Forms.Label();
            this.blackWinButton = new System.Windows.Forms.Label();
            this.whitePlayerBin = new Chess.Bin();
            this.blackPlayerBin = new Chess.Bin();
            this.framedChessboard = new Chess.FramedChessboard();
            this.gameClock = new Chess.GameClock();
            this.SuspendLayout();
            // 
            // blackPlayerName
            // 
            this.blackPlayerName.AutoSize = true;
            this.blackPlayerName.BackColor = System.Drawing.Color.Transparent;
            this.blackPlayerName.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blackPlayerName.ForeColor = System.Drawing.Color.Moccasin;
            this.blackPlayerName.Location = new System.Drawing.Point(813, 100);
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
            // whiteWinButton
            // 
            this.whiteWinButton.AutoSize = true;
            this.whiteWinButton.BackColor = System.Drawing.Color.Transparent;
            this.whiteWinButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.whiteWinButton.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.whiteWinButton.ForeColor = System.Drawing.Color.Moccasin;
            this.whiteWinButton.Location = new System.Drawing.Point(37, 53);
            this.whiteWinButton.Name = "whiteWinButton";
            this.whiteWinButton.Size = new System.Drawing.Size(77, 17);
            this.whiteWinButton.TabIndex = 12;
            this.whiteWinButton.Text = "Declare Win";
            // 
            // whiteResignButton
            // 
            this.whiteResignButton.AutoSize = true;
            this.whiteResignButton.BackColor = System.Drawing.Color.Transparent;
            this.whiteResignButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.whiteResignButton.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.whiteResignButton.ForeColor = System.Drawing.Color.Moccasin;
            this.whiteResignButton.Location = new System.Drawing.Point(130, 53);
            this.whiteResignButton.Name = "whiteResignButton";
            this.whiteResignButton.Size = new System.Drawing.Size(43, 17);
            this.whiteResignButton.TabIndex = 13;
            this.whiteResignButton.Text = "Resign";
            // 
            // drawButton
            // 
            this.drawButton.AutoSize = true;
            this.drawButton.BackColor = System.Drawing.Color.Transparent;
            this.drawButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.drawButton.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drawButton.ForeColor = System.Drawing.Color.Moccasin;
            this.drawButton.Location = new System.Drawing.Point(455, 53);
            this.drawButton.Name = "drawButton";
            this.drawButton.Size = new System.Drawing.Size(86, 17);
            this.drawButton.TabIndex = 14;
            this.drawButton.Text = "Agree on draw";
            // 
            // blackResignButton
            // 
            this.blackResignButton.AutoSize = true;
            this.blackResignButton.BackColor = System.Drawing.Color.Transparent;
            this.blackResignButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.blackResignButton.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blackResignButton.ForeColor = System.Drawing.Color.Moccasin;
            this.blackResignButton.Location = new System.Drawing.Point(912, 53);
            this.blackResignButton.Name = "blackResignButton";
            this.blackResignButton.Size = new System.Drawing.Size(43, 17);
            this.blackResignButton.TabIndex = 15;
            this.blackResignButton.Text = "Resign";
            // 
            // blackWinButton
            // 
            this.blackWinButton.AutoSize = true;
            this.blackWinButton.BackColor = System.Drawing.Color.Transparent;
            this.blackWinButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.blackWinButton.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blackWinButton.ForeColor = System.Drawing.Color.Moccasin;
            this.blackWinButton.Location = new System.Drawing.Point(815, 53);
            this.blackWinButton.Name = "blackWinButton";
            this.blackWinButton.Size = new System.Drawing.Size(77, 17);
            this.blackWinButton.TabIndex = 16;
            this.blackWinButton.Text = "Declare Win";
            // 
            // whitePlayerBin
            // 
            this.whitePlayerBin.BackColor = System.Drawing.Color.Transparent;
            this.whitePlayerBin.Location = new System.Drawing.Point(109, 184);
            this.whitePlayerBin.Margin = new System.Windows.Forms.Padding(0);
            this.whitePlayerBin.Name = "whitePlayerBin";
            this.whitePlayerBin.Size = new System.Drawing.Size(64, 0);
            this.whitePlayerBin.TabIndex = 11;
            // 
            // blackPlayerBin
            // 
            this.blackPlayerBin.BackColor = System.Drawing.Color.Transparent;
            this.blackPlayerBin.Location = new System.Drawing.Point(828, 184);
            this.blackPlayerBin.Margin = new System.Windows.Forms.Padding(0);
            this.blackPlayerBin.Name = "blackPlayerBin";
            this.blackPlayerBin.Size = new System.Drawing.Size(64, 0);
            this.blackPlayerBin.TabIndex = 10;
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
            // GameScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Chess.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.blackWinButton);
            this.Controls.Add(this.blackResignButton);
            this.Controls.Add(this.drawButton);
            this.Controls.Add(this.whiteResignButton);
            this.Controls.Add(this.whiteWinButton);
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
        private System.Windows.Forms.Label whiteWinButton;
        private System.Windows.Forms.Label whiteResignButton;
        private System.Windows.Forms.Label drawButton;
        private System.Windows.Forms.Label blackResignButton;
        private System.Windows.Forms.Label blackWinButton;
    }
}