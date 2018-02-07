using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//-----------------------------------------------------
namespace Builder
{
    class Car
    {
        private string carType;
        private Dictionary<string, string> parts = new Dictionary<string, string>();

        public Car(string carType)
        {
            this.carType = carType;
        }

        public string this[string key]
        {
            get { return parts[key]; }
            set { parts[key] = value; }
        }

        public void ToString()
        {
            Console.WriteLine("Vehicle Type: {0}", carType);
            Console.WriteLine(" Frame : {0}", parts["frame"]);
            Console.WriteLine(" Engine : {0}", parts["engine"]);
            Console.WriteLine(" Wheels: {0}", parts["wheels"]);
            Console.WriteLine(" Transmission : {0}", parts["transmission"]);
        }
    }
}
//-----------------------------------------------------