using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//------------------------------------------------
namespace Decorator
{
    class ElfWarrior : Character
    {
        public ElfWarrior(Character character)
        {
            if (character is Elf)
            {
                character.Name = "Elf Warrior";
                character.attack += 20;
                character.speed -= 10;
                character.health += 100;
                character.armor += 20;
            }
        }
    }
}
//------------------------------------------------