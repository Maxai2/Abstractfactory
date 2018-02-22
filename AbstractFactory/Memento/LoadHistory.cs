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
        public List<TextMemento> History = new List<TextMemento>();

        public int Selected { get; set; }

        public LoadHistory() => Selected = -1;

        public void Add(TextMemento memento)
        {
            History.Add(memento);
            Selected++;
        }

        public TextMemento this[int index]
        {
            get => History[index];
        }

        public TextMemento Undo()
        {
            if (History.Count == 0)
                return null;

            if (Selected > 0)
            {
                Selected--;
                return History[Selected];
            }
            else
                return History[Selected];
        }

        public TextMemento Rendo()
        {
            if (History.Count == 0)
                return null;

            if (Selected < History.Count - 1)
            {
                Selected++;
                return History[Selected];
            }
            else
                return History[Selected];
        }
    }
}
//-------------------------------------------------------------