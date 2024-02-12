using System.Drawing;

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
        FigureColor PieceColor { get; }
        FigureType Name { get; }
        Image Sprite { get; }

        bool CanMove(int x, int y);
        void Move(int x, int y);
    }
}
