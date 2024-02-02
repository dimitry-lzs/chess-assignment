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
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximumSize = new Size(1024, 1024);
            this.MinimumSize = new Size(1024, 1024);

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
