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
        public Elf()
        {
            Name = "Elf";
            attack += 15;
            speed += 30;
            health += 100;
            armor += 0;
        }
    }
}
//------------------------------------------------