using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    public class ChessBoard
    {
        private ChessFigure[,] _board = new ChessFigure[8,8];
        private List<ChessFigure> _activeFigures;

        /// <summary>
        /// Property for get ActiveFigures
        /// </summary>
        public List<ChessFigure> ActiveFigures
        {
            get { return _activeFigures; }
        }


        private bool setFigure(ChessFigure fig)
        {
            // TODO:
            // Check whether it is possible to add Figure with given location
            // i.e. Pawn not on the first or last row, etc.

            _board[fig.Position.x, fig.Position.y] = fig;
            return true;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="outOfBound"></param>
        /// <returns>Figure if associated with given coordinates, otherwise returns null</returns>
        public ChessFigure getFigure(int x, int y, out bool outOfBound)
        {
            if (x >= 0 && x < 8 && y >= 0 && y < 8)
            {
                outOfBound = false;
                return this._board[x, y];
            }
            outOfBound = true;
            return null;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns>Figure if associated with given coordinates, otherwise returns null</returns>
        public ChessFigure getFigure(int x, int y)
        {
            if (x >= 0 && x < 8 && y >= 0 && y < 8)
            {
                return this._board[x, y];
            }
            throw new IndexOutOfRangeException("accessing index: [" + x + " , " + y + "]");
        }

        public void createPosition(List<ChessFigure> figures)
        {
            destroyPosition();

            _activeFigures = figures;
            
            foreach(var fig in figures)
            {
                setFigure(fig);
            }
        }

        public void destroyPosition()
        {
            _board = new ChessFigure[8, 8];
        }




        public override string ToString()
        {
            string str = "";

            for (int y = 7; y >= 0; y--)
            {
                str += y + 1;
                for (int x = 0; x < 8; x++)
                {
                    var fig = getFigure(x,y);
                    if(null == fig)
                    {
                        str += "0";
                    }
                    else
                    {
                        str += fig.ToString()[0];
                    }
                }
                str += "\n";
            }
            str += "xabcdefgh\n";

            return str;
        }// ToString

    }
}
