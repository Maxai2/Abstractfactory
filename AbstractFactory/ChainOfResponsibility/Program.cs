using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//----------------------------------------------
namespace ChainOfResponsibility 
{
    class Program
    {
        static void Main(string[] args)
        {
            Handler ErrorHandler = new ErrorClass();
            Handler CErrorHandler = new CriticalErrorClass();
            Handler Error111Handler = new Error111Class();

            ErrorHandler.Successor = CErrorHandler;
            CErrorHandler.Successor = Error111Handler;

            ErrorHandler.Logging(3, "Error");
        }
    }
}
//----------------------------------------------