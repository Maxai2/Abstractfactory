using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//---------------------------------
namespace FlyWeight
{
    class ThirdPicture : Picture
    {
        public ThirdPicture() => path = Directory.GetCurrentDirectory() + @"\Pictures\Glasses.jpg";
    }
}
//---------------------------------