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
    }
}
//-----------------------------------------------------