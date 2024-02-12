namespace Chess
{
    partial class Clock
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
            this.digit1 = new Chess.Digit();
            this.digit2 = new Chess.Digit();
            this.digit3 = new Chess.Digit();
            this.digit4 = new Chess.Digit();
            this.SuspendLayout();
            // 
            // digit1
            // 
            this.digit1.BackColor = System.Drawing.Color.Transparent;
            this.digit1.Location = new System.Drawing.Point(100, 141);
            this.digit1.Name = "digit1";
            this.digit1.Size = new System.Drawing.Size(43, 81);
            this.digit1.TabIndex = 0;
            // 
            // digit2
            // 
            this.digit2.BackColor = System.Drawing.Color.Transparent;
            this.digit2.Location = new System.Drawing.Point(149, 141);
            this.digit2.Name = "digit2";
            this.digit2.Size = new System.Drawing.Size(43, 81);
            this.digit2.TabIndex = 1;
            // 
            // digit3
            // 
            this.digit3.BackColor = System.Drawing.Color.Transparent;
            this.digit3.Location = new System.Drawing.Point(247, 141);
            this.digit3.Name = "digit3";
            this.digit3.Size = new System.Drawing.Size(43, 81);
            this.digit3.TabIndex = 2;
            // 
            // digit4
            // 
            this.digit4.BackColor = System.Drawing.Color.Transparent;
            this.digit4.Location = new System.Drawing.Point(296, 141);
            this.digit4.Name = "digit4";
            this.digit4.Size = new System.Drawing.Size(43, 81);
            this.digit4.TabIndex = 1;
            // 
            // Clock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.digit4);
            this.Controls.Add(this.digit3);
            this.Controls.Add(this.digit2);
            this.Controls.Add(this.digit1);
            this.Name = "Clock";
            this.Size = new System.Drawing.Size(456, 222);
            this.ResumeLayout(false);

        }

        #endregion

        private Digit digit1;
        private Digit digit2;
        private Digit digit3;
        private Digit digit4;
    }
}
