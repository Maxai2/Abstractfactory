using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//------------------------------------------------
namespace Decorator
{
    class ElfWarrior : Decorator
    {
        public ElfWarrior(Character character)
        {
            if (character is Elf)
            {
                Character = character;
                Name = "Elf Warrior";
                attack += 20;
                speed -= 10;
                health += 100;
                armor += 20;
            }
        }
    }
}
//------------------------------------------------