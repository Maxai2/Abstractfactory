using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//------------------------------------------------
namespace Decorator
{
    class SwordMan : Character
    {
        public SwordMan(Character character)
        {
            if (character is HumanWarrior)
            {
                character.Name = "Sword Man";
                character.attack += 40;
                character.speed -= 10;
                character.health += 50;
                character.armor += 40;
            }
        }
    }
}
//------------------------------------------------