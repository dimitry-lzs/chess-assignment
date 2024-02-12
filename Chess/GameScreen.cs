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
    public partial class GameScreen : Form
    {
        Player[] players;
        Player PlayingPlayer;
        Player whitePlayer;
        Player blackPlayer;

        public GameScreen(Player player1, Player player2)
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.ResizeRedraw |
                                         ControlStyles.OptimizedDoubleBuffer |
                                                                  ControlStyles.AllPaintingInWmPaint, true);
            this.players = new Player[2];

            if (player1.PickedColor == FigureColor.White)
            {
                this.players[0] = player1;
                this.players[1] = player2;
                this.whitePlayer = player1;
                this.blackPlayer = player2;
            }
            else
            {
                this.players[0] = player2;
                this.players[1] = player1;
                this.whitePlayer = player2;
                this.blackPlayer = player1;
            }
        }

        public void SetPlayingPlayer()
        {
            this.PlayingPlayer = this.players[0];
            this.players[0] = this.players[1];
            this.players[1] = this.PlayingPlayer;
        }
    }
}
