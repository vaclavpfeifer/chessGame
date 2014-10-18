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


        public bool setFigure(ChessFigure fig)
        {
            _board[fig.Position.x, fig.Position.y] = fig;
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
            if (x >= 0 && x < 8 && y >= 0 && y < 8)
            {
                return this._board[x, y];
            }
            return null;
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

    }
}
