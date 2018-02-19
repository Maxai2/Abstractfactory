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
                character.Name = "Horse Man";
                character.attack -= 10;
                character.speed += 40;
                character.health += 200;
                character.armor += 100;
            }
        }
    }
}
//------------------------------------------------