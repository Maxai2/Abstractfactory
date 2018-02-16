﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//------------------------------------------------
namespace Decorator
{
    abstract class Human : Character
    {
        public Human(Character character)
        {
            character.Name = "Human";
            character.attack += 20;
            character.speed += 20;
            character.health += 150;
            character.armor += 0;
        }
    }
}
//------------------------------------------------