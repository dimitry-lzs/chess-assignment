using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chess
{
    public partial class NixieClock : UserControl
    {
        Timer timer;
        private int _SecondsRemaining;
        public int SecondsRemaining {
            get {
                return this._SecondsRemaining;
            }
            set {
                this._SecondsRemaining = value;
                if (this._SecondsRemaining < 0)
                {
                    this.Stop();
                }
                this.SetTime();
            }
        }

        public NixieClock()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.ResizeRedraw |
                ControlStyles.OptimizedDoubleBuffer |
                ControlStyles.AllPaintingInWmPaint, true);

            this.timer = new Timer();
            this.timer.Interval = 1000;
            this.timer.Tick += new EventHandler(timer_Tick);
            this.SecondsRemaining = 0;
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            this.Tick();
        }
        private void SetTime()
        {
            this.tensMinutes.DisplayDigit((this.SecondsRemaining / 60) / 10);
            this.minutes.DisplayDigit((this.SecondsRemaining / 60) % 10);
            this.tensSeconds.DisplayDigit((this.SecondsRemaining % 60) / 10);
            this.seconds.DisplayDigit(this.SecondsRemaining % 10);
            this.clockBlinker.Blink();
        }

        public void Tick()
        {
            this.SecondsRemaining--;
        }
        public void Start()
        {
            if (!this.timer.Enabled)
            {
                this.timer.Start();
            }
        }
        public void Stop()
        {
            if (this.timer.Enabled)
            {
                this.timer.Stop();
            }
        }

        private void Clock_Load(object sender, EventArgs e)
        {
            this.Start();
        }
    }
}
