namespace Chess
{
    partial class GameWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameWindow));
            this.setupGame1 = new Chess.SetupGame();
            this.SuspendLayout();
            // 
            // setupGame1
            // 
            this.setupGame1.BackColor = System.Drawing.Color.Transparent;
            this.setupGame1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.setupGame1.Location = new System.Drawing.Point(0, 0);
            this.setupGame1.Margin = new System.Windows.Forms.Padding(0);
            this.setupGame1.Name = "setupGame1";
            this.setupGame1.Size = new System.Drawing.Size(600, 320);
            this.setupGame1.TabIndex = 0;
            // 
            // GameWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Chess.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(604, 331);
            this.Controls.Add(this.setupGame1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(620, 370);
            this.MinimumSize = new System.Drawing.Size(620, 370);
            this.Name = "GameWindow";
            this.Text = "Game";
            this.ResumeLayout(false);

        }

        #endregion

        private SetupGame setupGame1;
    }
}