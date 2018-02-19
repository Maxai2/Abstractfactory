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
            string path = Directory.GetCurrentDirectory() + @"\Error.txt";

            if (ErrorLvl == 2)
            {
                if (!File.Exists(path))
                {
                    File.Create(path);
                    File.WriteAllText(path, ErrorText);
                }
                else
                    File.WriteAllText(path, ErrorText);
            }
            else
            {
                if (!File.Exists(path))
                {
                    File.Create(path);
                    File.WriteAllText(path, ErrorText);
                }
                else
                    File.WriteAllText(path, ErrorText);

                Successor.Logging(ErrorLvl, ErrorText);
            }
        }
    }
}
//----------------------------------------------