using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//-----------------------------------------------------
namespace Builder
{
    class Fabric
    {
        public void Construct(CarBuilder carBuilder)
        {
            carBuilder.BuildFrame();
            carBuilder.BuildEngine();
            carBuilder.BuildWheels();
            carBuilder.BuildTransmission();
        }
    }
}
//-----------------------------------------------------