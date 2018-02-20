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
                Character = character;
                Name = "Good Magician";
                attack += 50;
                speed += 30;
                health += 100;
                armor += 30;
            }
        }
    }
}
//------------------------------------------------