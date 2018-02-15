using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//------------------------------------------------
namespace Decorator
{
    abstract class Character
    {
        public string Name { get; set; }
        int Attack;
        int Speed;
        int Health;
        int Armor;

        public virtual int attack { get => Attack; set => Attack = value; }
        public virtual int speed { get => Speed; set => Speed = value; }
        public virtual int health { get => Health; set => Health = value; }
        public virtual int armor { get => Armor; set => Armor = value; }

        
    }
}
//------------------------------------------------