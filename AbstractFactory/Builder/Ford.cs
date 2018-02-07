using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//-----------------------------------------------------
namespace Builder
{
    class Ford : CarBuilder
    {
        public Ford()
        {
            car = new Car("Probe");
        }

        public override void BuildTransmission()
        {
            car["transmission"] = "4 Auto";
        }

        public override void BuildEngine()
        {
            car["engine"] = "160";
        }

        public override void BuildFrame()
        {
            car["frame"] = "coupe";
        }

        public override void BuildWheels()
        {
            car["wheels"] = "14";
        }
    }
}
//-----------------------------------------------------