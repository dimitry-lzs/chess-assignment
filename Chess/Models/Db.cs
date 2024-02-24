using ServiceStack.OrmLite;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;

namespace Chess.Models
{
    public class Db
    {
        IDbConnection DbConnection { get; set; }
        public Db()
        {
            var dbFilePath = "Chess.sqlite";
            var dbFactory = new OrmLiteConnectionFactory(dbFilePath, SqliteDialect.Provider);

            this.DbConnection = dbFactory.Open();
            this.DbConnection.CreateTableIfNotExists<PlayerModel>();
            this.DbConnection.CreateTableIfNotExists<Game>();
            this.DbConnection.CreateTableIfNotExists<Move>();
        }
        public void CreatePlayer(PlayerModel player)
        {
            this.DbConnection.Save(player);
        }
        public void CreateGame(Game game)
        {
            this.DbConnection.Save(game);
        }
        public void UpdateGame(Game game)
        {
            this.DbConnection.Update(game);
        }
        public void SaveMove(Move move)
        {
            this.DbConnection.Save(move);
        }
        public void Close()
        {
            this.DbConnection.Close();
        }
        public List<GameData> FetchGames()
        {
            List<Game> games = this.DbConnection.LoadSelect<Game>();
            List<GameData> gamesData = new List<GameData>();
            foreach (var game in games)
            {
                gamesData.Add(
                    new GameData
                    {
                        WhitePlayerName = game.WhitePlayer?.Name,
                        BlackPlayerName = game.BlackPlayer?.Name,
                        WinnerName = game.Winner?.Name,
                        StartTime = game.StartTime.ToString(),
                        EndTime = game.EndTime.ToString(),
                        DurationSeconds = game.DurationSeconds,
                        Result = game.Result
                    });
            }
            return gamesData;
        }
    }
    public class GameData
    {
        public string WhitePlayerName { get; set; }
        public string BlackPlayerName { get; set; }
        public string WinnerName { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
        public int DurationSeconds { get; set; }

        public string Result { get; set; }
    }
}
