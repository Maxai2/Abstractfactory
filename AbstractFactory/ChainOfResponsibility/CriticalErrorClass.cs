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
        public override void Logging(int ErrorLvl, string ErrorText)
        {
            string path = "Error.txt";

            using (StreamWriter sw = new StreamWriter(path))
            {
                sw.WriteLine(path, ErrorText);
            }

            Console.WriteLine($@"File Created: {Directory.GetCurrentDirectory()}\{path}");

            if (ErrorLvl != 2)
                Successor.Logging(ErrorLvl, ErrorText);
        }
    }
}
//----------------------------------------------