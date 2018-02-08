using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//--------------------------------------
namespace Bridge
{
    class CpuReporter : IReporter
    {
        public void GetInfo()
        {
            Console.WriteLine("i7-6700 GHz | 4-threads"); 
        }
    }
}
//--------------------------------------