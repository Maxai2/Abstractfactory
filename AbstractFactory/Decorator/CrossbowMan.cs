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
                Character = character;
                Name = "Crossbowman";
                attack += 20;
                speed += 10;
                health += 50;
                armor -= 10;
            }
        }
    }
}
//------------------------------------------------