using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//----------------------------------------------------
namespace AbstractFactory
{
    class Carnivore
    {
        public double Power { get; set; }

        public void Eat(Herbivore herbivore) 
        {
            if (herbivore.Weight <= Power)
                Power += 10;
            else
                Power -= 10;
        }
    }
}
//----------------------------------------------------