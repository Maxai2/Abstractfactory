using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//---------------------------------------------------
namespace FactoryMethod
{
    class L_Figure : Figure
    {
        // 30,144,255 dodgerblue
        public L_Figure()
        {
            figArr = new int[4, 4] { { 1, 0, 0, 0 }, { 1, 1, 1, 1 }, { 0, 0, 0, 0 }, { 0, 0, 0, 0 } };
            name = "L";
            Col.red = 30;
            Col.green = 144;
            Col.blue = 255;
        }
    }
}
//---------------------------------------------------