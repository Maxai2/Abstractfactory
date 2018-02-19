using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//------------------------------------------------
namespace Decorator
{
    class GoodMagician : Decorator
    {
        public GoodMagician(Character character)
        {
            if (character is ElfMagician)
            {
                character.Name = "Good Magician";
                character.attack += 50;
                character.speed += 30;
                character.health += 100;
                character.armor += 30;
            }
        }
    }
}
//------------------------------------------------