using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//------------------------------------------------
namespace Decorator
{
    class Human : Character
    {
        public Human()
        {
            Name = "Human";
            attack += 20;
            speed += 20;
            health += 150;
            armor += 0;
        }
    }
}
//------------------------------------------------