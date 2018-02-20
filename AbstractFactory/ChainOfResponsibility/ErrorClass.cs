using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//----------------------------------------------
namespace ChainOfResponsibility
{
    class ErrorClass : Handler
    {
        public override void Logging(MyException exception)
        {
            Console.WriteLine(exception.Message);

            if (exception.error != Errors.Error)
                Successor.Logging(exception);
        }
    }
}
//----------------------------------------------