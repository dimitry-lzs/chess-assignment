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

        // This flag is used to determine if the figure has moved at least once.
        // It is used to determine if the king can castle.
        bool HasMoved { get; set; }
        FigureColor PieceColor { get; }
        FigureType Name { get; }
        Image Sprite { get; }

        bool CanMove(int x, int y);
        void Move(int x, int y);
    }
}
