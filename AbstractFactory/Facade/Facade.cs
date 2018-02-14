using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//---------------------------------------------------
namespace Facade
{
    class Facade
    {
        Sensors sensors = new Sensors();
        RAM ram = new RAM();
        PowerSupply powerSupply = new PowerSupply();
        HDD hDD = new HDD();
        GPU gPU = new GPU();
        CD_DVD_Reader reader = new CD_DVD_Reader();

        public void BeginWork()
        {
            powerSupply.EnergizePC();
            sensors.CheckEnergize();
            sensors.CheckTempPW();
            sensors.CheckTempGPU();
            powerSupply.EnergizeGPU();
            gPU.Run();
            gPU.CheckConnectMonitorGPU();
            sensors.CheckTempRAM();
            powerSupply.EnergizeRAM();
            ram.Run();
            ram.Analise();
            gPU.RAMShow();
            powerSupply.EnergizeOpticDriver();
            reader.Run();
            reader.CheckDisc();
            gPU.OpticalDriveShow();
            powerSupply.EnergizeHDD();
            hDD.Run();
            hDD.Check();
            gPU.HDDShow();
            sensors.CheckAll();
        }

        public void FinishWork()
        {
            hDD.Stop();
            ram.Clear();
            ram.Analise();
            gPU.ByeMes();
            reader.GoBegin();
            powerSupply.StopEnergizeGPU();
            powerSupply.StopEnergizeRAM();
            powerSupply.StopEnergizeOpticDriver();
            powerSupply.StopEnergizeHDD();
            sensors.CheckEnergize();
            powerSupply.StopEnergizePC();
        }
    }
}
//---------------------------------------------------