using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//----------------------------------------------
namespace ChainOfResponsibility
{
    public enum Errors
    {
        Error,
        CriticalError,
        FatalError
    }

    class MyException : Exception
    {
        public Errors error { get; set; }

        public MyException(string text, Errors error) : base(text)
        {
            this.error = error;
        }
    }
}
//----------------------------------------------