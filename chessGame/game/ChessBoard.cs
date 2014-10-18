using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace game
{
    public class ChessBoard
    {
        private ChessFigure[,] _board = new ChessFigure[8,8];


        public ChessBoard()
        {

        }

        public bool setFigure(ChessFigure fig)
        {

            return true;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns>Figure if associated with given coordinates, otherwise returns null</returns>
        public ChessFigure getFigure(int x, int y)
        {
            return this._board[x, y];
        }

    }
}
