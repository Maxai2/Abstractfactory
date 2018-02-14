using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//---------------------------------------------------
namespace Facade
{
    class Sensors
    {
        public void CheckEnergize() => Console.WriteLine("Check voltage");

        public void CheckTempPW() => Console.WriteLine("Check PW Temp");

        public void CheckTempGPU() => Console.WriteLine("Check GPU Temp");

        public void CheckTempRAM() => Console.WriteLine("Check RAM Temp");

        public void CheckAll() => Console.WriteLine("Check All System");
    }
}
//---------------------------------------------------