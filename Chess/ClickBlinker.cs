using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chess
{
    public class ClickBlinker : Panel
    {
        private int _X = 13;
        private int _Y = 25;

        System.Drawing.Image BlinkerImage;
        private System.Drawing.Image[] blinkingImages = new System.Drawing.Image[2];

        Timer timer;
        public ClickBlinker()
        {
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.ResizeRedraw |
                               ControlStyles.OptimizedDoubleBuffer |
                                              ControlStyles.AllPaintingInWmPaint, true);
            this.BackColor = System.Drawing.Color.Transparent;

            this.blinkingImages[0] = Properties.Resources.center_bulb1;
            this.blinkingImages[1] = Properties.Resources.center_bulb2;
            this.BlinkerImage = this.blinkingImages[0];

            // For testing, normally clock controls it
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 500; // Timer will tick every 500 milliseconds (1/2 second)
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start(); // Start the timer
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            this.BlinkerImage = this.blinkingImages[0];
            this.blinkingImages[0] = this.blinkingImages[1];
            this.blinkingImages[1] = this.BlinkerImage;
            this.Refresh();
        }
        
        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.DrawImage(this.BlinkerImage, 0, 0, this._X, this._Y);
        }
    }
}
