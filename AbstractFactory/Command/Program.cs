using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//-----------------------------------------------
namespace Command
{
    class Program
    {
        static void Square()
        {
            Console.Write((char)218);

            for (int i = 0; i < 5; i++)
                Console.Write((char)196);

            Console.Write((char)191);

            for (int i = 1; i < 6; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    Console.SetCursorPosition(j, i);

                    if (j == 0 || j == 6 || j == 2 || j == 4)
                        Console.Write((char)179);
                    else
                    if (i == 2 || i == 4)
                        Console.Write((char)196);
                }
            }
            Console.WriteLine();

            Console.Write((char)192);

            for (int i = 0; i < 5; i++)
                Console.Write((char)196);

            Console.WriteLine((char)217);
        }

        static void Main(string[] args)
        {
            Square();


        }
    }
}
//-----------------------------------------------