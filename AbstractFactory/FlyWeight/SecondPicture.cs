using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//---------------------------------
namespace FlyWeight
{
    class SecondPicture : Picture
    {
        public SecondPicture() => path = Directory.GetCurrentDirectory() + @"\Pictures\Foxes.jpg";
    }
}
//---------------------------------