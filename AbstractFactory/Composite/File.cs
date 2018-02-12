using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//--------------------------------------------------
namespace Composite
{
    class File : Component
    {
        public File(string name) : base(name) 
        {}

        public override void Add(Component c)
        {
            throw new NotImplementedException();
        }

        public override void Display(int depth)
        {
            throw new NotImplementedException();
        }

        public override void Remove(Component c)
        {
            throw new NotImplementedException();
        }
    }
}
//--------------------------------------------------