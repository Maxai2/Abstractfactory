using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//------------------------------------------------
namespace Decorator
{
    class HorseMan : Decorator
    {
        public HorseMan(Character character)
        {
            if (character is SwordMan)
            {
                Character = character;
                Name = "Horse Man";
                attack -= 10;
                speed += 40;
                health += 200;
                armor += 100;
            }
        }
    }
}
//------------------------------------------------