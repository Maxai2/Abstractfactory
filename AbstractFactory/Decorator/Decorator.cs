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
        protected Character Character;

        int Attack;
        int Speed;
        int Health;
        int Armor;

        public override int armor { get => Armor + Character.armor; set => Armor = value; }
        public override int attack { get => Attack + Character.attack; set => Attack = value; }
        public override int health { get => Health + Character.health; set => Health = value; }
        public override int speed { get => Speed +  Character.speed; set => Speed = value; }
    }
}
//------------------------------------------------