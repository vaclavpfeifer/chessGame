using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    public interface IChessSolver
    {
        void solveProblem(ChessBoard board);
    }

    public class ChessSolverSimple : IChessSolver
    {
        void IChessSolver.solveProblem(ChessBoard board)
        {
            foreach(var fig in board.ActiveFigures)
            {
                Position newPos = fig.calcBestMove(board);

                if(newPos == fig.Position)// cant move
                {
                    Utility.Logger.INSTANCE().log(fig.ToString() + ", ERROR - unable to move at all" );
                }
                else if (null == board.getFigure(newPos.x, newPos.y)) // no figure
                {
                    Utility.Logger.INSTANCE().log(fig.ToString() + ", " + newPos.ToString() + 
                                                  ", no capture, chosen whatever");
                }
                else// captured new figure
                {
                    // TODO:
                    //  - check whether correct figure?

                    Utility.Logger.INSTANCE().log(fig.ToString() + ", " + newPos.ToString() +
                                                  ", captured");
                }

            }

        }// IChessSolver.solveProblem

    }// ChessSolverSimple
}
