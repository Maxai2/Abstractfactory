using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//---------------------------------------------------
namespace Facade
{
    class RAM
    {
        public void Run() => Console.WriteLine("RAM energize");

        public void Analise() => Console.WriteLine("RAM analise");

        public void Clear() => Console.WriteLine("RAM clear");
    }
}
//---------------------------------------------------