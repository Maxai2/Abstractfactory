using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//--------------------------------------------------
namespace Composite
{
    class Directory : Component
    {
        public Directory(string name) : base(name)
        {}

        private List<Component> list = new List<Component>();

        public override void Add(Component c) => list.Add(c);

        public override void Remove(Component c) => list.Remove(c); 

        public override void Display(int depth)
        {
            Console.WriteLine();
        }
    }
}
//--------------------------------------------------