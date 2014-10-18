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
            return FigureRank.KING;
        }

        public override Position calcBestMove(ChessBoard board)
        {
            throw new NotImplementedException();
        }
    }
}
