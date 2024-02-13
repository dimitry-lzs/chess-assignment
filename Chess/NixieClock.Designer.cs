namespace Chess
{
    partial class NixieClock
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
            this.clockBlinker = new Chess.NixieBlinker();
            this.seconds = new Chess.Nixie();
            this.tensSeconds = new Chess.Nixie();
            this.minutes = new Chess.Nixie();
            this.tensMinutes = new Chess.Nixie();
            this.SuspendLayout();
            // 
            // clockBlinker
            // 
            this.clockBlinker.BackColor = System.Drawing.Color.Transparent;
            this.clockBlinker.Location = new System.Drawing.Point(98, 53);
            this.clockBlinker.Name = "clockBlinker";
            this.clockBlinker.Size = new System.Drawing.Size(13, 25);
            this.clockBlinker.TabIndex = 3;
            // 
            // seconds
            // 
            this.seconds.BackColor = System.Drawing.Color.Transparent;
            this.seconds.Location = new System.Drawing.Point(166, 0);
            this.seconds.Name = "seconds";
            this.seconds.Size = new System.Drawing.Size(43, 81);
            this.seconds.TabIndex = 1;
            // 
            // tensSeconds
            // 
            this.tensSeconds.BackColor = System.Drawing.Color.Transparent;
            this.tensSeconds.Location = new System.Drawing.Point(117, 0);
            this.tensSeconds.Name = "tensSeconds";
            this.tensSeconds.Size = new System.Drawing.Size(43, 81);
            this.tensSeconds.TabIndex = 2;
            // 
            // minutes
            // 
            this.minutes.BackColor = System.Drawing.Color.Transparent;
            this.minutes.Location = new System.Drawing.Point(49, 0);
            this.minutes.Name = "minutes";
            this.minutes.Size = new System.Drawing.Size(43, 81);
            this.minutes.TabIndex = 1;
            // 
            // tensMinutes
            // 
            this.tensMinutes.BackColor = System.Drawing.Color.Transparent;
            this.tensMinutes.Location = new System.Drawing.Point(0, 0);
            this.tensMinutes.Name = "tensMinutes";
            this.tensMinutes.Size = new System.Drawing.Size(43, 81);
            this.tensMinutes.TabIndex = 0;
            // 
            // NixieClock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.clockBlinker);
            this.Controls.Add(this.seconds);
            this.Controls.Add(this.tensSeconds);
            this.Controls.Add(this.minutes);
            this.Controls.Add(this.tensMinutes);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "NixieClock";
            this.Size = new System.Drawing.Size(209, 77);
            this.Load += new System.EventHandler(this.Clock_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Nixie tensMinutes;
        private Nixie minutes;
        private Nixie tensSeconds;
        private Nixie seconds;
        private NixieBlinker clockBlinker;
    }
}
