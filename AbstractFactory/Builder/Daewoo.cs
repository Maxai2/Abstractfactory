using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//-----------------------------------------------------
namespace Builder
{
    class Daewoo : CarBuilder
    {
        public Daewoo()
        {
            car = new Car("Lanos");
        }

        public override void BuildTransmission()
        {
            car["transmission"] = "5 Manual";
        }

        public override void BuildEngine()
        {
            car["engine"] = "98";
        }

        public override void BuildFrame()
        {
            car["frame"] = "sedan";
        }

        public override void BuildWheels()
        {
            car["wheels"] = "13";
        }
    }
}
//-----------------------------------------------------