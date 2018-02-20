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
                Character = character;
                Name = "Evil Magician";
                attack += 70;
                speed += 20;
                health += 0;
                armor += 0;
            }
        }
    }
}
//------------------------------------------------