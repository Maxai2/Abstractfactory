using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//---------------------------------
namespace FlyWeight
{
    class FirstPicture : Picture
    {
        public FirstPicture() => path = Directory.GetCurrentDirectory() + @"\Pictures\FireExtinguisher.jpg";
    }
}
//---------------------------------