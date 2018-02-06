using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//----------------------------------------------------
namespace AbstractFactory
{  
    class AnimalWorld
    {
        public IContinent AnimalWorldFactory { get; set; }

        public void MealsHerbivores(Herbivore herbivore)
        {
            AnimalWorldFactory.creatHerbivore();
        }

        public void NutritonCarnivores(Carnivore carnivore)
        {
            AnimalWorldFactory.creatHerbivore();
        }
    }
}
//----------------------------------------------------