using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace game
{
    public enum Color
    {
        BLACK,
        WHITE
    }

    public enum FigureRank
    {
        KING = 0,
        QUEEN = 1,
        ROOT = 2,
        BISHOP = 3,
        JEZDEC = 4,
        PAWN = 5
    }

    public class Position
    {
        int x;
        int y;
    }

    public abstract class ChessFigure
    {
        protected Color _color;
        protected FigureRank _rank;
        protected Position _position;

        public abstract Position calcBestMove(ChessBoard board);
    }

    public class King : ChessFigure
    {
        public override Position calcBestMove(ChessBoard board)
        {
            throw new NotImplementedException();
        }
    }




}
