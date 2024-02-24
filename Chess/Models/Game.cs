using ServiceStack.OrmLite;
using ServiceStack.OrmLite.Sqlite;
using System;
using System.Collections.Generic;
using System.Data;
using ServiceStack.DataAnnotations;


namespace Chess.Models
{
    public class Game
    {
        [AutoIncrement]
        public int Id { get; set; }

        [ForeignKey(typeof(PlayerModel))]
        public int WhitePlayerId { get; set; }

        [ForeignKey(typeof(PlayerModel))]
        public int BlackPlayerId { get; set; }

        [ForeignKey(typeof(PlayerModel))]
        public int WinnerId { get; set; }

        public string Result { get; set; }

        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }

        [Ignore]
        public int DurationSeconds {
            get
            {
                return (int)(EndTime - StartTime).TotalSeconds;
            }
        }

        [Reference]
        public List<Move> Moves { get; set; }

        [Reference]
        public PlayerModel WhitePlayer { get; set; }

        [Reference]
        public PlayerModel BlackPlayer { get; set; }

        [Reference]
        public PlayerModel Winner { get; set; }

    }
    public enum ResultType
    {
        WhiteWins = 1,
        BlackWins = 2,
        WhiteResigns = 3,
        BlackResigns = 4,
        Draw = 5
    }
}
