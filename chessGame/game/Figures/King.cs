using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Figures
{
    public class King : ChessFigure
    {
        public override FigureRank getRank()
        {
            return FigureRank.KING;
        }

        public override Position calcBestMove(ChessBoard board)
        {
            Position newMove = new Position(this.Position);
            ChessFigure captFigure = null;
            bool outOfBound = false;

            // Up
            ChessFigure fig = board.getFigure(Position.x,
                                              Position.y + 1, out outOfBound);
            if (null != fig)
            {
                if (fig.Color != this.Color)
                {
                    captFigure = fig;
                }
            }
            else
            {
                // Set new move
                if (!outOfBound)
                {
                    newMove.x = Position.x ;
                    newMove.y = Position.y + 1;
                }
            }

            // Down
            outOfBound = false;
            fig = board.getFigure(Position.x,
                                  Position.y - 1, out outOfBound);
            if (null != fig)
            {
                if (fig.Color != this.Color)
                {
                    captFigure = fig;
                }
            }
            else
            {
                // Set new move
                if (!outOfBound)
                {
                    newMove.x = Position.x;
                    newMove.y = Position.y - 1;
                }
            }

            // Left
            outOfBound = false;
            fig = board.getFigure(Position.x - 1,
                                  Position.y, out outOfBound);
            if (null != fig)
            {
                if (fig.Color != this.Color)
                {
                    captFigure = fig;
                }
            }
            else
            {
                // Set new move
                if (!outOfBound)
                {
                    newMove.x = Position.x - 1;
                    newMove.y = Position.y;
                }
            }

            // Right
            outOfBound = false;
            fig = board.getFigure(Position.x,
                                  Position.y + 1, out outOfBound);
            if (null != fig)
            {
                if (fig.Color != this.Color)
                {
                    captFigure = fig;
                }
            }
            else
            {
                // Set new move
                if (!outOfBound)
                {
                    newMove.x = Position.x;
                    newMove.y = Position.y + 1;
                }
            }

            // Up-Right
            outOfBound = false;
            fig = board.getFigure(Position.x + 1,
                                  Position.y + 1, out outOfBound);
            if (null != fig)
            {
                if (fig.Color != this.Color)
                {
                    captFigure = fig;
                }
            }
            else
            {
                // Set new move
                if (!outOfBound)
                {
                    newMove.x = Position.x + 1;
                    newMove.y = Position.y + 1;
                }
            }

            // Up-Left
            outOfBound = false;
            fig = board.getFigure(Position.x - 1,
                                  Position.y + 1, out outOfBound);
            if (null != fig)
            {
                if (fig.Color != this.Color)
                {
                    captFigure = fig;
                }
            }
            else
            {
                // Set new move
                if (!outOfBound)
                {
                    newMove.x = Position.x - 1;
                    newMove.y = Position.y + 1;
                }
            }

            // Down-Right
            outOfBound = false;
            fig = board.getFigure(Position.x + 1,
                                  Position.y - 1, out outOfBound);
            if (null != fig)
            {
                if (fig.Color != this.Color)
                {
                    captFigure = fig;
                }
            }
            else
            {
                // Set new move
                if (!outOfBound)
                {
                    newMove.x = Position.x + 1;
                    newMove.y = Position.y - 1;
                }
            }

            // Down-Left
            outOfBound = false;
            fig = board.getFigure(Position.x - 1,
                                  Position.y - 1, out outOfBound);
            if (null != fig)
            {
                if (fig.Color != this.Color)
                {
                    captFigure = fig;
                }
            }
            else
            {
                // Set new move
                if (!outOfBound)
                {
                    newMove.x = Position.x - 1;
                    newMove.y = Position.y - 1;
                }
            }

            return captFigure != null ? captFigure.Position : newMove;
        }

    }



}
