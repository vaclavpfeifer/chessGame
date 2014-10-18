using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    public enum Color
    {
        BLACK,
        WHITE
    }

    public enum FigureRank
    {
        KING = 5,
        QUEEN = 4,
        ROOK = 3,
        BISHOP = 2,
        KNIGHT = 1,
        PAWN = 0
    }

    public class Position
    {
        public int x;
        public int y;

        public Position() { }

        public Position(Position newPos)
        {
            this.x = newPos.x;
            this.y = newPos.y;
        }

        public override bool Equals(object obj)
        {
            var eqTo = obj as Position;
 	        return (eqTo.x == this.x && eqTo.y == this.y);
        }

        // Change default implementation in case of usage as Keys 
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public static bool operator == (Position lhs, Position rhs)
        {
            if (object.ReferenceEquals(lhs, null))
            {
                return object.ReferenceEquals(rhs, null);
            }
            return lhs.Equals(rhs);
        }

        public static bool operator !=(Position lhs, Position rhs)
        {
            return !(lhs == rhs);
        }

        public override string ToString()
        {
            string str = "";
            str += Position.toLetterNotation(this.x);
            str += this.y + 1;
            return str;
        }

        public static char toLetterNotation(int posX)
        {
            int first = (int)'a';
            return (char)(first + posX);
        }

        public static int toIntegerNotation(char letter)
        {
            int first = (int)'a';
            int index = (int)letter - first;
            return index;
        }
    }

    public abstract class ChessFigure
    {
        protected Color _color;
        protected Position _position = new Position();

        public Color Color
        {
            get { return _color; }
            set { _color = value; }
        }
        public Position Position
        {
          get { return _position; }
          set { _position = value; }
        }

        public abstract FigureRank getRank();

        /// <summary>
        /// Calculate best possible move (if not possible to move, return current position).
        /// The best move is defined by the possible capture of the highest rank figure.
        /// </summary>
        /// <param name="board"></param>
        /// <returns></returns>
        public abstract Position calcBestMove(ChessBoard board);

        public override string ToString()
        {
            string str;
            string rankstr = "";

            switch(getRank())
            {
                case FigureRank.KING:
                    rankstr = "K";
                    break;

                case FigureRank.QUEEN:
                    rankstr = "Q";
                    break;

                case FigureRank.BISHOP:
                    rankstr = "B";
                    break;

                case FigureRank.ROOK:
                    rankstr = "R";
                    break;

                case FigureRank.KNIGHT:
                    rankstr = "N";
                    break;

                case FigureRank.PAWN:
                    rankstr = "P";
                    break;
            }

            str = _color == Color.WHITE ? rankstr.ToUpper() : rankstr.ToLower();
            str += Position.ToString();
            return str;
        }

    }



}
