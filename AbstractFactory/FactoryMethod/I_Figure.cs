using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//---------------------------------------------------
namespace FactoryMethod
{
    class I_Figure : Figure
    {
        public I_Figure()
        {
            // 0, 0, 255
            figArr = new int[4, 4] { { 1, 0, 0, 0 }, { 1, 0, 0, 0 }, { 1, 0, 0, 0 }, { 1, 0, 0, 0 } };
            Col.red = 0;
            Col.green = 0;
            Col.blue = 255;
            name = "I";
        }
    }
}
//---------------------------------------------------