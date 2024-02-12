namespace Chess
{
    public class Rook : Figure
    {
        public Rook(FigureColor color) : base(FigureType.Rook, color)
        {
            if (color == FigureColor.White)
            {
                this.Sprite = Properties.Resources.Chess_rlt60;
            }
            else
            {
                this.Sprite = Properties.Resources.Chess_rdt60;
            }
        }

        public override bool CanMove(int x, int y)
        {
            Figure targetCellFigure = this.Board.GetFigure(x, y);

            if (targetCellFigure == null || targetCellFigure.PieceColor != this.PieceColor)
            {
                if (this.X == x || this.Y == y)
                {
                    return true;
                }
            }

            return false;
        }
    }

}
