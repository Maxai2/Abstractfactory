using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//------------------------------------------------
namespace Decorator
{
    class ElfMagician : Decorator
    {
        public ElfMagician(Character character)
        {
            if (character is Elf)
            {
                Character = character;
                Name = "Elf Magician";
                attack += 10;
                speed += 10;
                health -= 50;
                armor += 10;
            }
        }
    }
}
//------------------------------------------------