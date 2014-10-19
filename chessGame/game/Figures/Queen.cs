using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Figures
{
    public class Queen : ChessFigure
    {
        public override FigureRank getRank()
        {
            return FigureRank.QUEEN;
        }

        public override Position calcBestMove(ChessBoard board)
        {
            Position newMove = new Position(this.Position);
            ChessFigure captFigure = null;
            bool outOfBound = false;

            int xIncr = 0;
            int yIncr = 1;
            // Up
            while (!outOfBound)
            {
                ChessFigure fig = board.getFigure(Position.x + xIncr,
                                                  Position.y + yIncr, out outOfBound);

                if (null != fig)
                {
                    if (fig.Color != this.Color)
                    {
                        captFigure = fig;
                    }
                    break;
                }
                else
                {
                    // Set new move
                    if (!outOfBound)
                    {
                        newMove.x = Position.x + xIncr;
                        newMove.y = Position.y + yIncr;
                    }
                }
                yIncr++;
            }

            // Down
            xIncr = 0;
            yIncr = 1;
            outOfBound = false;
            while (!outOfBound)
            {
                ChessFigure fig = board.getFigure(Position.x + xIncr,
                                                  Position.y - yIncr, out outOfBound);

                if (null != fig)
                {
                    if (fig.Color != this.Color)
                    {
                        if (null == captFigure)
                        {
                            captFigure = fig;
                        }
                        else if (fig.getRank() > captFigure.getRank())
                        {
                            captFigure = fig;
                        }
                    }
                    break;
                }
                else
                {
                    // Set new move
                    if (!outOfBound)
                    {
                        newMove.x = Position.x + xIncr;
                        newMove.y = Position.y - yIncr;
                    }
                }
                yIncr++;
            }

            // Right
            xIncr = 1;
            yIncr = 0;
            outOfBound = false;
            while (!outOfBound)
            {
                ChessFigure fig = board.getFigure(Position.x + xIncr,
                                                  Position.y + yIncr, out outOfBound);

                if (null != fig)
                {
                    if (fig.Color != this.Color)
                    {
                        if (null == captFigure)
                        {
                            captFigure = fig;
                        }
                        else if (fig.getRank() > captFigure.getRank())
                        {
                            captFigure = fig;
                        }
                    }
                    break;
                }
                else
                {
                    // Set new move
                    if (!outOfBound)
                    {
                        newMove.x = Position.x + xIncr;
                        newMove.y = Position.y + yIncr;
                    }
                }
                xIncr++;
            }

            // Left
            xIncr = 1;
            yIncr = 0;
            outOfBound = false;
            while (!outOfBound)
            {
                ChessFigure fig = board.getFigure(Position.x - xIncr,
                                                  Position.y + yIncr, out outOfBound);

                if (null != fig)
                {
                    if (fig.Color != this.Color)
                    {
                        if (null == captFigure)
                        {
                            captFigure = fig;
                        }
                        else if (fig.getRank() > captFigure.getRank())
                        {
                            captFigure = fig;
                        }
                    }
                    break;
                }
                else
                {
                    // Set new move
                    if (!outOfBound)
                    {
                        newMove.x = Position.x - xIncr;
                        newMove.y = Position.y + yIncr;
                    }
                }
                xIncr++;
            }

            xIncr = 1;
            yIncr = 1;
            // Right Upper quadrant
            while (!outOfBound)
            {
                ChessFigure fig = board.getFigure(Position.x + xIncr,
                                                  Position.y + yIncr, out outOfBound);

                if (null != fig)
                {
                    if (fig.Color != this.Color)
                    {
                        captFigure = fig;
                    }
                    break;
                }
                else
                {
                    // Set new move
                    if (!outOfBound)
                    {
                        newMove.x = Position.x + xIncr;
                        newMove.y = Position.y + yIncr;
                    }
                }
                xIncr++;
                yIncr++;
            }

            // Right bottom quadrant
            xIncr = 1;
            yIncr = 1;
            outOfBound = false;
            while (!outOfBound)
            {
                ChessFigure fig = board.getFigure(Position.x + xIncr,
                                                  Position.y - yIncr, out outOfBound);

                if (null != fig)
                {
                    if (fig.Color != this.Color)
                    {
                        if (null == captFigure)
                        {
                            captFigure = fig;
                        }
                        else if (fig.getRank() > captFigure.getRank())
                        {
                            captFigure = fig;
                        }
                    }
                    break;
                }
                else
                {
                    // Set new move
                    if (!outOfBound)
                    {
                        newMove.x = Position.x + xIncr;
                        newMove.y = Position.y - yIncr;
                    }
                }
                xIncr++;
                yIncr++;
            }

            // Left upper quadrant
            xIncr = 1;
            yIncr = 1;
            outOfBound = false;
            while (!outOfBound)
            {
                ChessFigure fig = board.getFigure(Position.x - xIncr,
                                                  Position.y + yIncr, out outOfBound);

                if (null != fig)
                {
                    if (fig.Color != this.Color)
                    {
                        if (null == captFigure)
                        {
                            captFigure = fig;
                        }
                        else if (fig.getRank() > captFigure.getRank())
                        {
                            captFigure = fig;
                        }
                    }
                    break;
                }
                else
                {
                    // Set new move
                    if (!outOfBound)
                    {
                        newMove.x = Position.x - xIncr;
                        newMove.y = Position.y + yIncr;
                    }
                }
                xIncr++;
                yIncr++;
            }

            // Left bottom quadrant
            xIncr = 1;
            yIncr = 1;
            outOfBound = false;
            while (!outOfBound)
            {
                ChessFigure fig = board.getFigure(Position.x - xIncr,
                                                  Position.y - yIncr, out outOfBound);

                if (null != fig)
                {
                    if (fig.Color != this.Color)
                    {
                        if (null == captFigure)
                        {
                            captFigure = fig;
                        }
                        else if (fig.getRank() > captFigure.getRank())
                        {
                            captFigure = fig;
                        }
                    }
                    break;
                }
                else
                {
                    // Set new move
                    if (!outOfBound)
                    {
                        newMove.x = Position.x - xIncr;
                        newMove.y = Position.y - yIncr;
                    }
                }
                xIncr++;
                yIncr++;
            }

            return captFigure != null ? captFigure.Position : newMove;
        }
    }
}
