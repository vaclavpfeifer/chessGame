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

        public override Position calcBestMove(ChessBoard board)
        {
            throw new NotImplementedException();
        }
    }
}
