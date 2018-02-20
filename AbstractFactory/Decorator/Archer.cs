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
                Character = character;
                Name = "Archer";
                attack += 20;
                speed += 20;
                health += 50;
                armor += 10;
            }
        }
    }
}
//------------------------------------------------