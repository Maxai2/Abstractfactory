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

        public Herbivore CreatHerbivores()
        {
            return AnimalWorldFactory.creatHerbivore();
        }

        public Carnivore CreatCarnivores()
        {
            return AnimalWorldFactory.creatCarnivore();
        }

        public void MealsHerbivores(Herbivore herbivore)
        {
            herbivore.EatGrass();
        }

        public void NutritionCarnivores(Carnivore carnivore, Herbivore herbivore)
        {
            carnivore.Eat(herbivore);
        }
    }
}
//----------------------------------------------------