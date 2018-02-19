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
            if (ErrorLvl == 1)
                Console.WriteLine(ErrorText);
            else
            {
                Console.WriteLine(ErrorText);

                Successor.Logging(ErrorLvl, ErrorText);
            }
        }
    }
}
//----------------------------------------------