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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            float dpiX, dpiY;
            using (Graphics graphics = this.CreateGraphics())
            {
                dpiX = graphics.DpiX;
                dpiY = graphics.DpiY;
            }

            // Calculate the size of the form in logical pixels
            int width = (int)(640 * (96 / dpiX));
            int height = (int)(640 * (96 / dpiY));

            // Set the client size of the form
            this.ClientSize = new Size(width, height);

            Bitmap transparentImage = new Bitmap(200, 200);
            for (int y = 0; y < transparentImage.Height; ++y)
            {
                for (int x = 0; x < transparentImage.Width; ++x)
                {
                    transparentImage.SetPixel(x, y, Color.Transparent);
                }
            }

            this.mainMenu.Image = transparentImage;
            this.Controls.Add(this.mainMenu);


            this.backgroundImage.Dock = DockStyle.Fill;
            this.backgroundImage.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Hello World!");
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
        }
    }
}
