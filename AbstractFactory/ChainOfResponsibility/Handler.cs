using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text; 
using System.Threading.Tasks;
//----------------------------------------------
namespace ChainOfResponsibility
{
    abstract class Handler
    {
        public Handler Successor { get; set; }
        public abstract void Logging(int ErrorLvl, string ErrorText);
    }
}
//----------------------------------------------