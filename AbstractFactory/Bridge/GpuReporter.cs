using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//--------------------------------------
namespace Bridge
{
    class GpuReporter : IReporter
    {
        public void GetInfo()
        {
            Console.WriteLine("NVidea 960m | 2 Gb");
        }
    }
}
//--------------------------------------