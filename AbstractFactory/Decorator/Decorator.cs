using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//------------------------------------------------
namespace Decorator
{
    class Decorator : Character
    {
        Character Character;

        int Attack;
        int Speed;
        int Health;
        int Armor;

        public override int armor { get => armor + Character.armor; set => base.armor = value; }
        public override int attack { get => base.attack; set => base.attack = value; }
        public override int health { get => base.health; set => base.health = value; }
        public override int speed { get => base.speed; set => base.speed = value; }
    }
}
//------------------------------------------------