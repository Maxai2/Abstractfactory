using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//------------------------------------------------
namespace Decorator
{
    class CrossbowMan : Decorator
    {
        public CrossbowMan(Character character)
        {
            if (character is ElfWarrior)
            {
                character.Name = "Crossbowman";
                character.attack += 20;
                character.speed += 10;
                character.health += 50;
                character.armor -= 10;
            }
        }
    }
}
//------------------------------------------------