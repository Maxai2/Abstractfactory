using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
//--------------------------------------------------
namespace Composite
{
    class MyDirectory : Component
    {
        public MyDirectory(string path, string name, double size) : base(name, size) => scanFile(this, path); 

        private List<Component> list = new List<Component>();

        public override void Add(Component c) => list.Add(c);

        public override void Remove(Component c) => list.Remove(c);

        public override void Display(int depth)
        {
            Console.WriteLine(new String(' ', depth) + name + " size:" + Size);

            foreach (Component item in list)
            {
                item.Display(depth + 2);
            }
        }

        void scanFile(MyDirectory directory, string path)
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(path);
            double size = 0;
            MyDirectory NewDirectory = null;

            foreach (var item in directoryInfo.GetDirectories())
            {
                if (item.Exists)
                {
                    NewDirectory = new MyDirectory(item.FullName, item.Name, 0);
                    Add(NewDirectory);
                }
            }

            foreach (var item in directoryInfo.GetFiles())
            {
                directory.Add(new MyFile(item.Name, item.Length));
                size += item.Length;
            }

            if (NewDirectory != null)
            {
                foreach (var item in list)
                    directory.Size += item.Size;
            }
            else
                directory.Size = size;
        }
    }
}
//--------------------------------------------------