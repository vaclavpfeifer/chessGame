using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    public class ChessFigureBuilder
    {
        private static ChessFigureBuilder _instance = new ChessFigureBuilder();
        private Dictionary<char, Type> _registeredTypes
            = new Dictionary<char, Type>();

        private ChessFigureBuilder()
        {
            // registration
            _registeredTypes.Add('k', typeof(Figures.King));
            _registeredTypes.Add('q', typeof(Figures.Queen));
            _registeredTypes.Add('r', typeof(Figures.Rook));
            _registeredTypes.Add('b', typeof(Figures.Bishop));
            _registeredTypes.Add('n', typeof(Figures.Knight));
            _registeredTypes.Add('p', typeof(Figures.Pawn));
        }

        public static ChessFigureBuilder INSTANCE()
        {
            return _instance;
        }

        // Do not checking validity of inputs!! 
        // Expecting correct format only!
        public ChessFigure createChessFigure(string str)
        {
            char rank = str[0];
            ChessFigure figure = null;
            if (_registeredTypes.Keys.Contains(char.ToLower(rank)))
            {
                figure = (ChessFigure)Activator.CreateInstance(_registeredTypes[char.ToLower(rank)]);
            }
            else
            {
                throw new NotSupportedException("Not supported Type of figure");
            }


            if(char.IsUpper(rank))
            {
                figure.Color = Color.WHITE;
            }
            else
            {
                figure.Color = Color.BLACK;
            }

            figure.Position.x = Position.toIntegerNotation(str[1]);
            figure.Position.y = str[2] - '0';
            return figure;
        }

    }
}
