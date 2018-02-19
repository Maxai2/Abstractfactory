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

        public override int armor { get => armor + Character.armor; set => Character.armor = value; }
        public override int attack { get => attack + Character.attack; set => Character.attack = value; }
        public override int health { get => health + Character.health; set => Character.health = value; }
        public override int speed { get => speed +  Character.speed; set => Character.speed = value; }

        public void ShowStat()
        {
            Console.WriteLine($"Name: {Name}, Attack: {attack}, Speed: {speed}, Health: {health}, Armor: {armor}");
        }
    }
}
//------------------------------------------------