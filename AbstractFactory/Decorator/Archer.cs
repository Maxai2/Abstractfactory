using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//------------------------------------------------
namespace Decorator
{
    class Archer : Decorator
    {
        public Archer(Character character)
        {
            if (character is HumanWarrior)
            {
                character.Name = "Archer";
                character.attack += 20;
                character.speed += 20;
                character.health += 50;
                character.armor += 10;
            }
        }
    }
}
//------------------------------------------------