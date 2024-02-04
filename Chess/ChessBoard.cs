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
            this.DoubleBuffered = true;
            this.FillGrid();
        }

        private void FillGrid()
        {
            for (int i = 0; i < BOARD_SIZE; i++)
            {
                for (int j = 0; j < BOARD_SIZE; j++)
                {
                    Panel square = new Panel();
                    square.BackColor = (i + j) % 2 == 0 ? Color.Moccasin : Color.FromArgb(101, 67, 33);
                    square.Location = new Point(i * SQUARE_SIZE, j * SQUARE_SIZE);
                    square.Size = new Size(SQUARE_SIZE, SQUARE_SIZE);
                    this.Controls.Add(square);
                }
            }
        }

        private void PlaceFigures()
        {
            for (int i = 0; i < BOARD_SIZE; i++)
            {
                for (int j = 0; j < BOARD_SIZE; j++)
                {
                    PictureBox piece = new PictureBox();

                    if (j == 0)
                    {
                        switch (i)
                        {
                            case 0:
                                piece.Image = Image.FromFile("Chess_rlt60.png");
                                break;
                            case 1:
                                piece.Image = Image.FromFile("Chess_nlt60.png");
                                break;
                            case 2:
                                piece.Image = Image.FromFile("Chess_blt60.png");
                                break;
                            case 3:
                                piece.Image = Image.FromFile("Chess_klt60.png");
                                break;
                            case 4:
                                piece.Image = Image.FromFile("Chess_qlt60.png");
                                break;
                            case 5:
                                piece.Image = Image.FromFile("Chess_blt60.png");
                                break;
                            case 6:
                                piece.Image = Image.FromFile("Chess_nlt60.png");
                                break;
                            case 7:
                                piece.Image = Image.FromFile("Chess_rlt60.png");
                                break;
                        }
                    } else if (j == 1)
                    {
                        piece.Image = Image.FromFile("Chess_plt60.png");
                    } else if (j == 6)
                    {
                        piece.Image = Image.FromFile("Chess_pdt60.png");
                    } else if (j == 7)
                    {
                        switch (i)
                        {
                            case 0:
                                piece.Image = Image.FromFile("Chess_rdt60.png");
                                break;
                            case 1:
                                piece.Image = Image.FromFile("Chess_ndt60.png");
                                break;
                            case 2:
                                piece.Image = Image.FromFile("Chess_bdt60.png");
                                break;
                            case 3:
                                piece.Image = Image.FromFile("Chess_kdt60.png");
                                break;
                            case 4:
                                piece.Image = Image.FromFile("Chess_qdt60.png");
                                break;
                            case 5:
                                piece.Image = Image.FromFile("Chess_bdt60.png");
                                break;
                            case 6:
                                piece.Image = Image.FromFile("Chess_ndt60.png");
                                break;
                            case 7:
                                piece.Image = Image.FromFile("Chess_rdt60.png");
                                break;
                        }
                    }   

                    piece.Cursor = Cursors.Hand;
                    this.Controls[i * BOARD_SIZE + j].Controls.Add(piece);
                }
            }
        }   

        private void ChessBoard_Load(object sender, EventArgs e)
        {
            this.Size = new Size(BOARD_SIZE * SQUARE_SIZE, BOARD_SIZE * SQUARE_SIZE);
            this.Location = new Point(30, 100);
            this.PlaceFigures();
        }
    }
}
