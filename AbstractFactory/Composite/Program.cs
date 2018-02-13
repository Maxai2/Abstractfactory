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
        static string[] GetFolders(string path) => Directory.GetDirectories(path);

        static string[] GetFiles(string path) => Directory.GetFiles(path);


        //MyDirectory directory = new MyDirectory(path.Substring(path.LastIndexOf('\\') + 1));

        static void Main(string[] args)
        {
            string path = "";
            Console.Write("Input link: ");
            path = Console.ReadLine();

            MyDirectory file = new MyDirectory(path, path.Substring(path.LastIndexOf('\\') + 1), 0);

            file.Display(0);

            //Console.WriteLine($"Count: {GetFolders(path).Length + GetFiles(path).Length}");

            //foreach (var item in GetFolders(path))
            //{
            //    Console.WriteLine(item);
            //}

            //foreach (var item in GetFiles(path))
            //{
            //    Console.WriteLine(item);
            //}

            //MyDirectory root = new MyDirectory("C");

            //MyDirectory comp = new MyDirectory("Folder1");
            //comp.Add(new MyFile("File1"));
            //comp.Add(new MyFile("File2"));
            //root.Add(comp);

            //root.Add(new MyFile("File1"));
            //root.Add(new MyFile("File2"));
            //root.Add(new MyFile("File3"));

            //MyFile leaf = new MyFile("File5");
            //root.Add(leaf);
            //root.Remove(leaf);

            //root.Display(0);
        }
    }
}
//--------------------------------------------------