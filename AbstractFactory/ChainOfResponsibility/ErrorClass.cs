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
        public override void Logging(int ErrorLvl, string ErrorText)
        {
            Console.WriteLine(ErrorText);

            if (ErrorLvl != 1)
                Successor.Logging(ErrorLvl, ErrorText);
        }
    }
}
//----------------------------------------------