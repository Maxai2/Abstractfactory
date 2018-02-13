using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//--------------------------------------------------
namespace Composite
{
    abstract class Component
    {
        protected string name;

        public double Size { get; set; }

        public Component(string name, double size)
        {
            this.name = name;
            this.Size = size;
        }

        public abstract void Add(Component c);
        public abstract void Remove(Component c);
        public abstract void Display(int depth);
    }
}
//--------------------------------------------------