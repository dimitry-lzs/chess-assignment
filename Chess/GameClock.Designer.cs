namespace Chess
{
    partial class GameClock
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
            this.nixieClockBlack = new Chess.NixieClock();
            this.nixieClockWhite = new Chess.NixieClock();
            this.SuspendLayout();
            // 
            // nixieClockBlack
            // 
            this.nixieClockBlack.BackColor = System.Drawing.Color.Transparent;
            this.nixieClockBlack.Location = new System.Drawing.Point(343, 0);
            this.nixieClockBlack.Name = "nixieClockBlack";
            this.nixieClockBlack.SecondsRemaining = 900;
            this.nixieClockBlack.Size = new System.Drawing.Size(209, 83);
            this.nixieClockBlack.TabIndex = 1;
            // 
            // nixieClockWhite
            // 
            this.nixieClockWhite.BackColor = System.Drawing.Color.Transparent;
            this.nixieClockWhite.Location = new System.Drawing.Point(0, 0);
            this.nixieClockWhite.Name = "nixieClockWhite";
            this.nixieClockWhite.SecondsRemaining = 900;
            this.nixieClockWhite.Size = new System.Drawing.Size(209, 83);
            this.nixieClockWhite.TabIndex = 0;
            // 
            // GameClock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.nixieClockBlack);
            this.Controls.Add(this.nixieClockWhite);
            this.Name = "GameClock";
            this.Size = new System.Drawing.Size(552, 80);
            this.ResumeLayout(false);

        }

        #endregion

        private NixieClock nixieClockWhite;
        private NixieClock nixieClockBlack;
    }
}
