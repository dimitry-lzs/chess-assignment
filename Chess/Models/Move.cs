using System;
using ServiceStack.DataAnnotations;


namespace Chess.Models
{
    public class Move
    {
        [AutoIncrement]
        public int Id { get; set; }
        [ForeignKey(typeof(Game))]
        public int GameId { get; set; }
        [ForeignKey(typeof(PlayerModel))]
        public int PlayerId { get; set; }
        public string From { get; set; }
        public string To { get; set; }
        public DateTime Time { get; set; }
        public FigureType figureName { get; set; }
        public virtual Game Game { get; set; }
        public virtual PlayerModel Player { get; set; }
    }
}
