using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//------------------------------------------------
namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Character human = new Human();
            Decorator decorator = new HorseMan(new SwordMan(new HumanWarrior(new Human())));

            //Decorator decorator = new HumanWarrior(human);
            decorator.ShowStat();
            //human.ShowStat();
        }
    }
}
//------------------------------------------------