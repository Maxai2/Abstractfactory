using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//-----------------------------------------------------
namespace Builder
{
    class UAZ : CarBuilder
    {
        public UAZ()
        {
            car = new Car("Patriot");
        }

        public override void BuildTransmission()
        {
            car["transmission"] = "4 Manual";
        }

        public override void BuildEngine()
        {
            car["engine"] = "120";
        }

        public override void BuildFrame()
        {
            car["frame"] = "universal";
        }

        public override void BuildWheels()
        {
            car["wheels"] = "16";
        }
    }
}
//-----------------------------------------------------