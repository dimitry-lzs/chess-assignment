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
    public partial class ChessBoard : UserControl
    {
        private const int BOARD_SIZE = 8;
        private const int SQUARE_SIZE = 64;

        public ChessBoard()
        {
            InitializeComponent();
            this.fillGrid();
        }

        private void fillGrid()
        {
            for (int i = 0; i < BOARD_SIZE; i++)
            {
                for (int j = 0; j < BOARD_SIZE; j++)
                {
                    PictureBox square = new PictureBox();
                    square.BackColor = (i + j) % 2 == 0 ? Color.Moccasin : Color.FromArgb(101, 67, 33);
                    ;
                    square.Location = new Point(i * SQUARE_SIZE, j * SQUARE_SIZE);
                    square.Size = new Size(SQUARE_SIZE, SQUARE_SIZE);
                    this.Controls.Add(square);
                }
            }
        }


        private void ChessBoard_Load(object sender, EventArgs e)
        {
            this.Size = new Size(BOARD_SIZE * SQUARE_SIZE, BOARD_SIZE * SQUARE_SIZE);
            this.Location = new Point(30, 100);
        }
    }
}
