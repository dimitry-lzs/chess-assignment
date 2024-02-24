using Chess.Models;

namespace Chess
{
    public class Player
    {
        public PlayerModel playerModel { get; set; }
        public bool Lost;
        public GameScreen gameScreen;
        public string Name { get; set; }
        public int SecondsRemaining { get; set; }
        public Figure[] Trophies { get; set; }
        public FigureColor PickedColor { get; set; }
        public Player(string name, FigureColor color)
        {
            this.Name = name;
            this.PickedColor = color;
            this.Trophies = new Figure[16];
            this.playerModel = new PlayerModel();
            this.playerModel.Name = name;
            this.playerModel.PickedColor = color;
        }
        public bool CanMove(FigureColor color)
        {
            return color == this.PickedColor;
        }
        public void LostByTime()
        {
            this.Lost = true;
            this.gameScreen.EndGame(this.PickedColor == FigureColor.White ? ResultType.BlackWins : ResultType.WhiteWins);
            using (TimeEnded timeEnded = new TimeEnded(this))
            {
                timeEnded.lostPlayerName.Text = this.Name + " lost by time";
                timeEnded.ShowDialog();
            }
        }
    }
}
