using System.Collections.Generic;
using ServiceStack.DataAnnotations;

namespace Chess.Models
{
    [Alias("Player")]
    public class PlayerModel
    {
        [AutoIncrement]
        public int Id { get; set; }
        public string Name { get; set; }
        public FigureColor PickedColor { get; set; }
    }
}
