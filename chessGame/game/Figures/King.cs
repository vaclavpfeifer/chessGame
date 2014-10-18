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

            return this.Position;
        }

    }



}
