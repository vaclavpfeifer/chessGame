using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Figures
{
    class Knight : ChessFigure
    {
        public override FigureRank getRank()
        {
            return FigureRank.KNIGHT;
        }

        public override Position calcBestMove(ChessBoard board)
        {
            Position newMove = new Position(this.Position);
            ChessFigure captFigure = null;
            bool outOfBound = false;


            // Up-Left
            ChessFigure fig = board.getFigure(Position.x - 1,
                                              Position.y + 2, out outOfBound);
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
                    newMove.y = Position.y + 2;
                }
            }

            // Up-Right
            outOfBound = false;
            fig = board.getFigure(Position.x + 1,
                                  Position.y + 2, out outOfBound);
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
                    newMove.y = Position.y + 2;
                }
            }

            // Down-Left
            outOfBound = false;
            fig = board.getFigure(Position.x - 1,
                                  Position.y - 2, out outOfBound);
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
                    newMove.y = Position.y - 2;
                }
            }

            // Down-Right
            outOfBound = false;
            fig = board.getFigure(Position.x + 1,
                                  Position.y - 2, out outOfBound);
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
                    newMove.y = Position.y - 2;
                }
            }

            // Left-Up
            outOfBound = false;
            fig = board.getFigure(Position.x - 2,
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
                    newMove.x = Position.x - 2;
                    newMove.y = Position.y + 1;
                }
            }

            // Left-Down
            outOfBound = false;
            fig = board.getFigure(Position.x - 2,
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
                    newMove.x = Position.x - 2;
                    newMove.y = Position.y - 1;
                }
            }

            // Right-Up
            outOfBound = false;
            fig = board.getFigure(Position.x + 2,
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
                    newMove.x = Position.x + 2;
                    newMove.y = Position.y + 1;
                }
            }

            // Right-Down
            outOfBound = false;
            fig = board.getFigure(Position.x + 2,
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
                    newMove.x = Position.x + 2;
                    newMove.y = Position.y - 1;
                }
            }

            return captFigure != null ? captFigure.Position : newMove;
        }
    }
}
