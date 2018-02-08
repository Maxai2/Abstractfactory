using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//-------------------------------------------------------
namespace Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            PcReporter pcReporter = new PcReporter();

            pcReporter.Report = new HDDReporter();
            pcReporter.getInfo();
            pcReporter.Report = new CpuReporter();
            pcReporter.getInfo();
            pcReporter.Report = new GpuReporter();
            pcReporter.getInfo();
        }
    }
}
//-------------------------------------------------------