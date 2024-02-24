using Chess.Models;
using System;
using System.Data.Entity;
using System.Data.SQLite;
using System.Windows.Forms;


namespace Chess
{
    public partial class GameScreen : UserControl
    {
        Player[] players;
        ChessBoard chessBoard;

        Player _PlayingPlayer;
        public Db Database { get; set; }
        public Game game { get; set; }
        Player PlayingPlayer
        {
            get { return this._PlayingPlayer; }
            set
            {
                if (this._PlayingPlayer != null)
                {
                    this.gameClock.Press(this._PlayingPlayer); // Player presses clock after making move
                }
                this._PlayingPlayer = value;
                this.chessBoard.playingPlayer = value;
            }
        }
        private Player _whitePlayer;
        public Player whitePlayer
        {
            get { return this._whitePlayer; }

            set
            {
                this._whitePlayer = value;
                this.whitePlayerName.Text = value.Name;
            }
        }

        private Player _blackPlayer;
        public Player blackPlayer
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
            player1.gameScreen = this;
            player2.gameScreen = this;
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
            this.chessBoard = this.framedChessboard.chessBoard;
            this.chessBoard.gameScreen = this;
            this.gameClock.whitePlayerClock.player = this.whitePlayer;
            this.gameClock.blackPlayerClock.player = this.blackPlayer;

            this.Database = new Db();

            this.Database.CreatePlayer(this.whitePlayer.playerModel);
            this.Database.CreatePlayer(this.blackPlayer.playerModel);

            this.game = new Game() { WhitePlayerId = this.whitePlayer.playerModel.Id, BlackPlayerId = this.blackPlayer.playerModel.Id, StartTime = DateTime.Now };
            this.Database.CreateGame(this.game);
        }

        public void SetPlayingPlayer()
        {
            this.PlayingPlayer = this.players[0];
            this.players[0] = this.players[1];
            this.players[1] = this.PlayingPlayer;
        }

        public void discardFigure(Figure figure)
        {
            if (figure.PieceColor == FigureColor.White)
            {
                this.blackPlayerBin.discardFigure(figure);
            }
            else
            {
                this.whitePlayerBin.discardFigure(figure);
            }
        }

        private void GameScreen_Load(object sender, EventArgs e)
        {
            this.Parent.ClientSize = this.Size;
            this.Parent.MinimumSize = this.Parent.Size;
            this.Parent.MaximumSize = this.Parent.Size;
            this.SetPlayingPlayer();
            this.gameClock.Initialize(600);
            this.gameClock.Press(this.blackPlayer);
        }
        public void EndGame(ResultType result)
        {
            this.game.EndTime = DateTime.Now;
            switch (result)
            {
                case ResultType.WhiteWins:
                    this.game.Result = "White wins";
                    this.game.WinnerId = this.whitePlayer.playerModel.Id;
                    break;
                case ResultType.BlackWins:
                    this.game.Result = "Black wins";
                    this.game.WinnerId = this.blackPlayer.playerModel.Id;
                    break;
                case ResultType.WhiteResigns:
                    this.game.Result = "White resigns";
                    this.game.WinnerId = this.blackPlayer.playerModel.Id;
                    break;
                case ResultType.BlackResigns:
                    this.game.Result = "Black resigns";
                    this.game.WinnerId = this.whitePlayer.playerModel.Id;
                    break;
                case ResultType.Draw:
                    this.game.Result = "Draw";
                    break;
            }

            this.Database.UpdateGame(this.game);
            this.gameClock.Stop();

            using (GameEnded gameEnded = new GameEnded(this.game))
            {
                gameEnded.ShowDialog();
                if (gameEnded.DialogResult == DialogResult.OK)
                {
                    this.Parent.Dispose();
                }
            }
        }

        private void whiteWinButton_Click(object sender, EventArgs e)
        {
            this.EndGame(ResultType.WhiteWins);
        }

        private void whiteResignButton_Click(object sender, EventArgs e)
        {
            this.EndGame(ResultType.WhiteResigns);
        }

        private void blackWinButton_Click(object sender, EventArgs e)
        {
            this.EndGame(ResultType.BlackWins);
        }

        private void blackResignButton_Click(object sender, EventArgs e)
        {
            this.EndGame(ResultType.BlackResigns);
        }

        private void drawButton_Click(object sender, EventArgs e)
        {
            this.EndGame(ResultType.Draw);
        }
    }
}
