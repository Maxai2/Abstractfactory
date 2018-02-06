using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//----------------------------------------------------
namespace AbstractFactory
{
    class Eurasia : IContinent
    {
        public Carnivore creatCarnivore()
        {
            return new Tiger();
        }

        public Herbivore creatHerbivore()
        {
            return new Elk();
        }
    }
}
//----------------------------------------------------