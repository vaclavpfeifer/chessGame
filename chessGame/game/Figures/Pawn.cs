using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Figures
{
    class Pawn : ChessFigure
    {
        public override FigureRank getRank()
        {
            return FigureRank.PAWN;
        }

        // Method assumes that Figure is on a valid location!
        public override Position calcBestMove(ChessBoard board)
        {
            Position newMove = new Position(this.Position);
            ChessFigure captFigure = null;
            bool outOfBound = false;

            // check left sife
            ChessFigure fig = board.getFigure(Position.x + 1, Position.y + 1, out outOfBound);
            if(null != fig)
            {
                if(fig.Color != this.Color)
                {
                    captFigure = fig;
                }
            }

            // check right sife
            fig = board.getFigure(Position.x - 1, Position.y + 1, out outOfBound);
            if (null != fig)
            {
                // Must be oposite color with higher rank
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
            }

            // TODO:
            //  - En passant



            // Check for move
            if(Color.WHITE == this.Color)
            {
                if(null == (fig = board.getFigure(Position.x, Position.y + 1, out outOfBound)))
                {
                    if (!outOfBound)
                    {
                        newMove.x = Position.x;
                        newMove.y = Position.y + 1;
                    }
                }
            }
            else
            {
                if (null == (fig = board.getFigure(Position.x, Position.y - 1, out outOfBound)))
                {
                    if (!outOfBound)
                    {
                        newMove.x = Position.x;
                        newMove.y = Position.y - 1;
                    }
                }
            }

            return captFigure != null ? captFigure.Position : newMove;
        }// calcBestMove
    }
}
