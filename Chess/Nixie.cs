using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chess
{
    internal class DigitCanvas : Panel
    {
        private System.Drawing.Image digitImage;
        private int _Value;
        private int _X = 43;
        private int _Y = 41;
        public int Value
        {
            get
            {
                return _Value;
            }
            set
            {
                switch (value)
                {
                    case 0:
                        this.digitImage = Properties.Resources._0;
                        break;
                    case 1:
                        this.digitImage = Properties.Resources._1;
                        break;
                    case 2:
                        this.digitImage = Properties.Resources._2;
                        break;
                    case 3:
                        this.digitImage = Properties.Resources._3;
                        break;
                    case 4:
                        this.digitImage = Properties.Resources._4;
                        break;
                    case 5:
                        this.digitImage = Properties.Resources._5;
                        break;
                    case 6:
                        this.digitImage = Properties.Resources._6;
                        break;
                    case 7:
                        this.digitImage = Properties.Resources._7;
                        break;
                    case 8:
                        this.digitImage = Properties.Resources._8;
                        break;
                    case 9:
                        this.digitImage = Properties.Resources._9;
                        break;
                    default:
                        this.digitImage = null;
                        break;
                }
                _Value = value;
                this.Refresh();
            }
        }
        public DigitCanvas()
        {
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.ResizeRedraw |
                ControlStyles.OptimizedDoubleBuffer |
                ControlStyles.AllPaintingInWmPaint, true);
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            if (this.digitImage != null) { e.Graphics.DrawImage(this.digitImage, 0, 0, this._X, this._Y); }
        }
    }
    public class Nixie : Panel
    {
        DigitCanvas canvas;
        private int _X = 43;
        private int _Y = 81;

        public Nixie()
        {
            this.BackColor = System.Drawing.Color.Transparent;
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.ResizeRedraw |
               ControlStyles.OptimizedDoubleBuffer |
               ControlStyles.AllPaintingInWmPaint, true);

            this.BorderStyle = System.Windows.Forms.BorderStyle.None;

            this.canvas = new DigitCanvas();
            this.canvas.Location = new System.Drawing.Point(0, 27);
            this.canvas.BackColor = System.Drawing.Color.Transparent;

            this.Controls.Add(canvas);
            this.canvas.BringToFront();
            this.DisplayDigit(0);
        }
        public void DisplayDigit(int digit)
        {
            this.canvas.Value = digit;
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.DrawImage(Properties.Resources.digit_bg_off, 0, 0, this._X, this._Y);
        }
    }
}
