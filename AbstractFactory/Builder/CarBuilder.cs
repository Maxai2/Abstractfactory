using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//-----------------------------------------------------
namespace Builder
{
    abstract class CarBuilder
    {
        protected Car car;

        public Car Car
        {
            get { return car; }
        }

        public abstract void BuildFrame();
        public abstract void BuildEngine();
        public abstract void BuildWheels();
        public abstract void BuildTransmission();
    }
}
//-----------------------------------------------------