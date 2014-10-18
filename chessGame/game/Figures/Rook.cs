using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Figures
{
    public class Rook : ChessFigure
    {
        public override FigureRank getRank()
        {
            return FigureRank.ROOK;
        }

        public override Position calcBestMove(ChessBoard board)
        {
            throw new NotImplementedException();
        }
    }
}
