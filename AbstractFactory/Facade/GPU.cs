using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//---------------------------------------------------
namespace Facade
{
    class GPU
    {
        public void Run() => Console.WriteLine("Run GPU");

        public void CheckConnectMonitorGPU() => Console.WriteLine("Check Connection");

        public void RAMShow() => Console.WriteLine("RAM Info Show");

        public void OpticalDriveShow() => Console.WriteLine("Optical Drive Info Show");

        public void HDDShow() => Console.WriteLine("HDD Info Show");

        public void ByeMes() => Console.WriteLine("Shut Down");
    }
}
//---------------------------------------------------