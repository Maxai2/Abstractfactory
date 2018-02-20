using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//------------------------------------------------
namespace Decorator
{
    class HumanWarrior : Decorator
    {
        public HumanWarrior(Character character)
        {
            if (character is Human)
            {
                Character = character;
                Name = "Human Warrior";
                attack += 20;
                speed += 10;
                health += 50;
                armor += 20;
            }
        }
    }
}
//------------------------------------------------