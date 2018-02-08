using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//---------------------------------------------------
namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Figure figure;

            FigureBuilder figureBuilder = new L_FigureBuilder();
            figure = figureBuilder.Create();

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (figure.figArr[i, j] == 1)
                    {
                        Console.SetCursorPosition(j, i);
                        Console.Write('*');
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
//---------------------------------------------------