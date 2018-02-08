using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//--------------------------------------
namespace Bridge
{
    class HDDReporter : IReporter
    {
        public void GetInfo()
        {
            Console.WriteLine("WD Blue | 1 Tb");
        }
    }
}
//--------------------------------------