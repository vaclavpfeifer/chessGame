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
            throw new NotImplementedException();
        }
    }
}
