using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//----------------------------------
namespace Command
{
    abstract class Command
    {
        abstract public void Redo();
        abstract public void Undo();
    }
}
//----------------------------------