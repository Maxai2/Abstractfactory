using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//---------------------------------------------------
namespace Facade
{
    class PowerSupply
    {
        public void EnergizePC() => Console.WriteLine("PW energize");

        public void EnergizeGPU() => Console.WriteLine("GPU energize");

        public void EnergizeRAM() => Console.WriteLine("RAM energize");

        public void EnergizeOpticDriver() => Console.WriteLine("Optical Drive energize");

        public void EnergizeHDD() => Console.WriteLine("HDD energize");

        public void StopEnergizeGPU() => Console.WriteLine("GPU stop energize");

        public void StopEnergizeRAM() => Console.WriteLine("RAM stop energize");

        public void StopEnergizeOpticDriver() => Console.WriteLine("Optical Drive stop energize");

        public void StopEnergizeHDD() => Console.WriteLine("HDD stop energize");

        public void StopEnergizePC() => Console.WriteLine("PW stop energize");
    }
}
//---------------------------------------------------