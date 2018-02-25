using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Command
{
    public class Reciever
    {

        public void Operation(ref PictureBox box)
        {
            string path = Directory.GetCurrentDirectory();

            if (box.Image == Image.FromFile(path + @"\Cross.png"))
                box.Image = Image.FromFile(path + @"\Circle.png");
            else
                box.Image = Image.FromFile(path + @"\Cross.png");
        }
    }
}
