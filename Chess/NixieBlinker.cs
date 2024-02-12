using System;
using System.Windows.Forms;

namespace Chess
{
    public class NixieBlinker : Panel
    {
        private int _X = 13;
        private int _Y = 25;

        System.Drawing.Image BlinkerImage;
        private System.Drawing.Image[] blinkingImages = new System.Drawing.Image[2];

        Timer timer;
        public NixieBlinker()
        {
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.ResizeRedraw |
                               ControlStyles.OptimizedDoubleBuffer |
                                              ControlStyles.AllPaintingInWmPaint, true);
            this.BackColor = System.Drawing.Color.Transparent;

            this.blinkingImages[0] = Properties.Resources.center_bulb2;
            this.blinkingImages[1] = Properties.Resources.center_bulb1;
            this.BlinkerImage = this.blinkingImages[0];

            timer = new System.Windows.Forms.Timer();
            timer.Interval = 500; // Timer will tick every 500 milliseconds (1/2 second)
            this.timer.Tick += new EventHandler(timer_Tick);
        }

        public void Blink()
        {
            this.BlinkerImage = this.blinkingImages[0];
            this.Refresh();
            this.timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            this.BlinkerImage = this.blinkingImages[1];
            this.timer.Stop();
            this.Refresh();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.DrawImage(this.BlinkerImage, 0, 0, this._X, this._Y);
        }
    }
}
