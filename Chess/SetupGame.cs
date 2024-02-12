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
    public partial class SetupGame : UserControl
    {
        
        public SetupGame()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.ResizeRedraw |
                          ControlStyles.OptimizedDoubleBuffer |
                          ControlStyles.AllPaintingInWmPaint, true);
        }

        private void beginGame_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Add(new ChessBoard());
            this.Parent.Controls.Remove(this);
            Player whitesPlayer = new Player(this.whitePlayerName.Text, FigureColor.White);
            Player blacksPlayer = new Player(this.blackPlayerName.Text, FigureColor.Black);
        }
    }
}
