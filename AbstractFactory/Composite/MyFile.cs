using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//--------------------------------------------------
namespace Composite
{
    class MyFile : Component
    {
        public MyFile(string name, double size) : base(name, size) {}

        public override void Add(Component c) => throw new NotImplementedException();

        public override void Remove(Component c) => throw new NotImplementedException(); 

        public override void Display(int depth) => Console.WriteLine(new String(' ', depth) + name + " size:" + Size); 
    }
}
//--------------------------------------------------