using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
//---------------------------------------------------
namespace Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            Facade facade = new Facade();

            facade.BeginWork();

            Thread.Sleep(1000);
            Console.WriteLine();

            facade.FinishWork();
        }
    }
}
//---------------------------------------------------