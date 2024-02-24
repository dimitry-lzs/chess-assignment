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
        public List<Game> FetchGames()
        {
            return this.DbConnection.Select<Game>();
        }
    }
}
