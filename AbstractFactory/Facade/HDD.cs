using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//---------------------------------------------------
namespace Facade
{
    class HDD
    {
        public void Run() => Console.WriteLine("Run HDD");

        public void Check() => Console.WriteLine("Check Boot Sector");

        public void Stop() => Console.WriteLine("Stop HDD");
    }
}
//---------------------------------------------------