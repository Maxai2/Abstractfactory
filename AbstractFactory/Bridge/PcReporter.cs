using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//--------------------------------------
namespace Bridge
{
    class PcReporter
    {
        public IReporter Report { get; set; }

        public void getInfo()
        {
            Report.GetInfo();
        }
    }
}
//--------------------------------------