using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//-------------- --------------------------------------
namespace AbstractFactory
{
    abstract class Herbivore
    {
        public double Weight { get; set; }
        public bool Life { get; set; }

        public void EatGrass()
        {
            Weight += 10;
        }
    }
}
//----------------------------------------------------