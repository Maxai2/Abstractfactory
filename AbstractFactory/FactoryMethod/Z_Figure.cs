using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//---------------------------------------------------
namespace FactoryMethod
{
    class Z_Figure : Figure
    {
        public Z_Figure()
        {
            // 255, 0, 102
            figArr = new int[4, 4] { { 1, 1, 0, 0 }, { 0, 1, 1, 0 }, { 0, 0, 0, 0 }, { 0, 0, 0, 0 } };
            Col.red = 255;
            Col.green = 0;
            Col.blue = 102;
            name = "Z";
        }
    }
}
//---------------------------------------------------