using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//---------------------------------
namespace FlyWeight
{
    class FourthPicture : Picture
    {
        public FourthPicture() => path = Directory.GetCurrentDirectory() + @"\Pictures\Road.jpg";
    }
}
//---------------------------------