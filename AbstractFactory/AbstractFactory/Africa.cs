using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//----------------------------------------------------
namespace AbstractFactory
{
    class Africa : IContinent
    { 
        public Carnivore creatCarnivore()
        {
            return new Lion();
        }

        public Herbivore creatHerbivore()
        {
            return new Wildebeest();
        }
    }
}
//----------------------------------------------------