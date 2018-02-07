using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//-----------------------------------------------------
namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            CarBuilder car;

            Fabric fabric = new Fabric();

            car = new UAZ();
            fabric.Construct(car);
            car.Car.ToString();

            car = new Ford();
            fabric.Construct(car);
            car.Car.ToString();

            car = new Daewoo();
            fabric.Construct(car);
            car.Car.ToString();

            car = new Hyundai();
            fabric.Construct(car);
            car.Car.ToString();
        }
    }
}
//-----------------------------------------------------