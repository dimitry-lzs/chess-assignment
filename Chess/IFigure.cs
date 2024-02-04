using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

public enum FigureColor
{
    White,
    Black
}

public enum FigureType
{
    Pawn,
    Rook,
    Knight,
    Bishop,
    Queen,
    King
}

namespace Chess
{
    public interface IFigure
    {
        int X { get; set; }
        int Y { get; set; }
        bool HasMoved { get; set; }
        FigureColor Color { get; }
        FigureType Name { get; }
        PictureBox Picture { get; }

        bool CanMove(int x, int y);
        void Move(int x, int y);
    }
}
