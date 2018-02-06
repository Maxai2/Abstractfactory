using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//----------------------------------------------------
namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            AnimalWorld AfricaWorld = new AnimalWorld();
            AfricaWorld.AnimalWorldFactory = new Africa();

            Herbivore herbivore = AfricaWorld.CreatHerbivores();
            Carnivore carnivore = AfricaWorld.CreatCarnivores();

        }
    }
}
//----------------------------------------------------