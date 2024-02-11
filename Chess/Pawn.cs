using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chess
{
    public class Pawn : Figure
    {
        public Pawn(FigureColor color) : base(FigureType.Pawn, color)
        {
            if (color == FigureColor.White)
            {
                this.Sprite = System.Drawing.Image.FromFile("Chess_plt60.png");
            }
            else
            {
                this.Sprite = System.Drawing.Image.FromFile("Chess_pdt60.png");
            }
        }

        public override bool CanMove(int x, int y)
        {
            Figure targetCellFigure = this.Board.GetFigure(x, y);
            if (this.PieceColor == FigureColor.White)
            {
                if (targetCellFigure == null)
                {
                    if (this.Y == 1)
                    {
                        if (this.X == x && (y == 2 || y == 3))
                        {
                            if (y == 3)
                            {
                                this.Board.EnPassantTarget = this;
                            } else
                            {
                                this.Board.EnPassantTarget = null;
                            }
                            return true;
                        }
                    }
                    if (this.X == x && y == this.Y + 1)
                    {
                        this.Board.EnPassantTarget = null;
                        return true;
                    }
                    Figure enPassantCell = this.Board.GetFigure(x, y - 1);
                    if (enPassantCell != null && enPassantCell == this.Board.EnPassantTarget)
                    {
                        this.Board.PerformEnPassant();
                        return true;
                    }
                }
                else if (Math.Abs(this.X - x) == 1 && y == this.Y + 1 && targetCellFigure.PieceColor == FigureColor.Black)
                {
                    this.Board.EnPassantTarget = null;
                    return true;
                }
            }
            else
            {
                if (targetCellFigure == null)
                {
                    if (this.Y == 6)
                    {
                        if (this.X == x && (y == 5 || y == 4))
                        {
                            if (y == 4)
                            {
                                this.Board.EnPassantTarget = this;
                            } else
                            {
                                this.Board.EnPassantTarget = null;
                            }
                            return true;
                        }
                    }
                    if (this.X == x && y == this.Y - 1)
                    {
                        this.Board.EnPassantTarget = null;
                        return true;
                    }
                    Figure enPassantCell = this.Board.GetFigure(x, y + 1);
                    if (enPassantCell != null && enPassantCell == this.Board.EnPassantTarget)
                    {
                        this.Board.PerformEnPassant();
                        return true;
                    }
                } else if (Math.Abs(this.X - x) == 1 && y == this.Y - 1 && targetCellFigure.PieceColor == FigureColor.White)
                {
                    this.Board.EnPassantTarget = null;
                    return true;
                }
            }
            return false;
        }

        public void Promote()
        {
            using (PromotionForm promotionForm = new PromotionForm(this.PieceColor))
            {
                if (promotionForm.ShowDialog() == DialogResult.OK)
                {
                    FigureType promotion = promotionForm.selectedPromotion;
                    this.Board.PromotePawn(this, promotion);
                }
            }
        }
    }
}
