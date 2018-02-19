using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//------------------------------------------------
namespace Decorator
{
    class EvilMagician : Decorator
    {
        public EvilMagician(Character character)
        {
            if (character is ElfMagician)
            {
                character.Name = "Evil Magician";
                character.attack += 70;
                character.speed += 20;
                character.health += 0;
                character.armor += 0;
            }
        }
    }
}
//------------------------------------------------