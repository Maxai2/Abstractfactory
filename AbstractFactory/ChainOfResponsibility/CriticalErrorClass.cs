using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//----------------------------------------------
namespace ChainOfResponsibility
{
    class CriticalErrorClass : Handler
    {
        public override void Logging(MyException exception)
        {
            string path = "Error.txt";

            using (StreamWriter sw = new StreamWriter(path))
            {
                sw.WriteLine(path, exception.Message);
            }

            Console.WriteLine($@"File Created: {Directory.GetCurrentDirectory()}\{path}");

            if (exception.error != Errors.CriticalError)
                Successor.Logging(exception);
        }
    }
}
//----------------------------------------------