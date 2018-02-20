using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//------------------------------------------------
namespace Decorator
{
    class SwordMan : Decorator
    {
        public SwordMan(Character character)
        {
            if (character is HumanWarrior)
            {
                Character = character;
                Name = "Sword Man";
                attack += 40;
                speed -= 10;
                health += 50;
                armor += 40;
            }
        }
    }
}
//------------------------------------------------