using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//--------------------------------------------------
namespace Composite
{
    class Program
    {
        static string[] GetFolder(string path) => Directory.GetDirectories(path);

        static string[] GetFile(string path) => Directory.GetFiles(path);

        static void Main(string[] args)
        {
            string path = "";
            Console.Write("Input the path for calculate: ");
            path = Console.ReadLine();

            MyDirectory directory = new MyDirectory(path.Substring(path.LastIndexOf('\\') + 1));



            directory.Display(0);
            
            
            
            
            
            //Console.WriteLine($"Count: {GetFolder(path).Length + GetFile(path).Length}");

            //foreach (var item in GetFolder(path))
            //{
            //    Console.WriteLine(item);
            //}

            //foreach (var item in GetFile(path))
            //{
            //    Console.WriteLine(item);
            //}

            //MyDirectory root = new MyDirectory("C");

            //root.Add(new MyFile("File1"));
            //root.Add(new MyFile("File2"));

            //MyDirectory comp = new MyDirectory("Folder3");
            //comp.Add(new MyFile("File3"));
            //comp.Add(new MyFile("File4"));
            //root.Add(comp);

            //root.Add(new MyFile("File5"));

            //MyFile leaf = new MyFile("File5");
            //root.Add(leaf);
            ////root.Remove(leaf);

            //root.Display(0);
        }
    }
}
//--------------------------------------------------