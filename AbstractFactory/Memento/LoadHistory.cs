using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//-------------------------------------------------------------
namespace Memento
{
    class LoadHistory
    {
        public Stack<TextMemento> History { get; private set; }
        public LoadHistory()
        {
            History = new Stack<TextMemento>();
        }
    }
}
//-------------------------------------------------------------