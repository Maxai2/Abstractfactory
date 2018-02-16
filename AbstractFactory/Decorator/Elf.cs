using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//------------------------------------------------
namespace Decorator
{
    class Elf : Character
    {
        public Elf(Character character)
        {
            character.Name = "Elf";
            character.attack += 15;
            character.speed += 30;
            character.health += 100;
            character.armor += 0;
        }
    }
}
//------------------------------------------------