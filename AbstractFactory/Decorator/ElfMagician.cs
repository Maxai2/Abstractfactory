using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//------------------------------------------------
namespace Decorator
{
    class ElfMagician : Character
    {
        public ElfMagician(Character character)
        {
            if (character is Elf)
            {
                character.Name = "Elf Magician";
                character.attack += 10;
                character.speed += 10;
                character.health -= 50;
                character.armor += 10;
            }
        }
    }
}
//------------------------------------------------