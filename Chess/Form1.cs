﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.ResizeRedraw |
                          ControlStyles.OptimizedDoubleBuffer |
                          ControlStyles.AllPaintingInWmPaint, true);

            StartScreen startScreen = new StartScreen();
            startScreen.Visible = false;
            this.Controls.Add(this.startScreen);
            startScreen.Visible = true;
        }
    }
    public static class GlobalSettings
    {
        public static readonly string BasePath = AppDomain.CurrentDomain.BaseDirectory;
    }
}
