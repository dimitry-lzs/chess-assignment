namespace Chess
{
    partial class StartScreen
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
            this.startButton = new System.Windows.Forms.Label();
            this.historyButton = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // startButton
            // 
            this.startButton.AutoSize = true;
            this.startButton.BackColor = System.Drawing.Color.Transparent;
            this.startButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.startButton.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.ForeColor = System.Drawing.Color.Moccasin;
            this.startButton.Location = new System.Drawing.Point(17, 0);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(105, 45);
            this.startButton.TabIndex = 5;
            this.startButton.Text = "Start";
            this.startButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // historyButton
            // 
            this.historyButton.AutoSize = true;
            this.historyButton.BackColor = System.Drawing.Color.Transparent;
            this.historyButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.historyButton.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.historyButton.ForeColor = System.Drawing.Color.Moccasin;
            this.historyButton.Location = new System.Drawing.Point(1, 90);
            this.historyButton.Name = "historyButton";
            this.historyButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.historyButton.Size = new System.Drawing.Size(135, 45);
            this.historyButton.TabIndex = 6;
            this.historyButton.Text = "History";
            this.historyButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.historyButton.Click += new System.EventHandler(this.historyButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.AutoSize = true;
            this.exitButton.BackColor = System.Drawing.Color.Transparent;
            this.exitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.ForeColor = System.Drawing.Color.Moccasin;
            this.exitButton.Location = new System.Drawing.Point(27, 180);
            this.exitButton.Name = "exitButton";
            this.exitButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.exitButton.Size = new System.Drawing.Size(83, 45);
            this.exitButton.TabIndex = 7;
            this.exitButton.Text = "Exit";
            this.exitButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // StartScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.historyButton);
            this.Controls.Add(this.exitButton);
            this.Name = "StartScreen";
            this.Size = new System.Drawing.Size(138, 227);
            this.Load += new System.EventHandler(this.StartScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label startButton;
        private System.Windows.Forms.Label historyButton;
        private System.Windows.Forms.Label exitButton;
    }
}
