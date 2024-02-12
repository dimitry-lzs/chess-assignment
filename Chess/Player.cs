using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    public class Player
    {
        public string Name { get; set; }
        public int SecondsRemaining { get; set; }
        public Figure[] Trophies { get; set; }
        public FigureColor PickedColor { get; set; }
        public Player(string name, FigureColor color)
        {
            this.Name = name;
            this.PickedColor = color;
            this.Trophies = new Figure[16];
        }
        public bool CanMove (FigureColor color)
        {
            return color == this.PickedColor;
        }
    }
}
