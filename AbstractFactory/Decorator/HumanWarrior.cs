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
                character.Name = "Human Warrior";
                character.attack += 20;
                character.speed += 10;
                character.health += 50;
                character.armor += 20;
            }
        }
    }
}
//------------------------------------------------