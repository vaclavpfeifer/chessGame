using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class Program
    {
        static void Main(string[] args)
        {            
            Console.WriteLine("The game has begun!");
            ChessBoard newBoard = new ChessBoard();
            List<ChessFigure> figures = new List<ChessFigure>();

            // TODO:
            //  - change to accept input parameter!
            string fileName = ".\\input.txt";

            Utility.Logger.INSTANCE().FileName = fileName + ".out";

            try
            {
                // Load figures from the file
                string line;
                System.IO.StreamReader reader = new System.IO.StreamReader(fileName);
                while ((line = reader.ReadLine()) != null)
                {
                    try
                    {
                        figures.Add(ChessFigureBuilder.INSTANCE().createChessFigure(line));
                    }
                    catch(NotSupportedException e)
                    {
                        Console.WriteLine(e.Message);
                    }
                }

                // create chess position
                newBoard.createPosition(figures);


                // Solve problem
                IChessSolver solver = new ChessSolverSimple();
                solver.solveProblem(newBoard);

            }
            catch(System.IO.IOException)
            {
                Console.WriteLine("File does not exists!");
            }
            catch(Exception)
            {
                Console.WriteLine("Unhandled Exception!");
            }


            Console.ReadKey();
        }// Main


    }
}
