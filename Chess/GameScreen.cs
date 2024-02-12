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
    public partial class GameScreen : UserControl
    {
        Player[] players;
        ChessBoard chessBoard;

        Player _PlayingPlayer;
        Player PlayingPlayer
        {
            get { return this._PlayingPlayer; }
            set
            {
                this.gameClock.Press(this._PlayingPlayer); // Player presses clock after making move
                this._PlayingPlayer = value;

            }
        }
        private Player _whitePlayer;
        Player whitePlayer
        {
            get { return this._whitePlayer; }

        set {
            this._whitePlayer = value;
                this.whitePlayerName.Text = value.Name;
            }
        }

        private Player _blackPlayer;
        Player blackPlayer
        {
            get { return this._blackPlayer; }

            set
            {
                this._blackPlayer = value;
                this.blackPlayerName.Text = value.Name;
            }
        }

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
            this.chessBoard = this.framedChessboard.ChessBoard;
        }

        public void SetPlayingPlayer()
        {
            this.PlayingPlayer = this.players[0];
            this.players[0] = this.players[1];
            this.players[1] = this.PlayingPlayer;
        }

        private void GameScreen_Load(object sender, EventArgs e)
        {
            this.Parent.ClientSize = this.Size;
            this.Parent.MinimumSize = this.Parent.Size;
            this.Parent.MaximumSize = this.Parent.Size;
            this.SetPlayingPlayer();
            this.gameClock.Press(this.blackPlayer);
        }
    }
}
