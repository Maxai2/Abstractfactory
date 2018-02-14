using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//---------------------------------------------------
namespace Facade
{
    class CD_DVD_Reader
    {
        public void Run() => Console.WriteLine("Run Optical Drive");

        public void CheckDisc() => Console.WriteLine("Check Disc");

        public void GoBegin() => Console.WriteLine("Return To Beginner State");
    }
}
//---------------------------------------------------