using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//---------------------------------
namespace FlyWeight
{
    class FifthPicture : Picture    
    {
        public FifthPicture() => path = Directory.GetCurrentDirectory() + @"\Pictures\Sunset.jpg";
    }
}
//---------------------------------