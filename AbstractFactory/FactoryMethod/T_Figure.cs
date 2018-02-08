using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//---------------------------------------------------
namespace FactoryMethod
{
    class T_Figure : Figure
    {
        public T_Figure()
        {
            // 255, 255, 0
            figArr = new int[4, 4] { { 0, 1, 0, 0 }, { 1, 1, 1, 0 }, { 0, 0, 0, 0 }, { 0, 0, 0, 0 } };
            Col.red = 255;
            Col.green = 255;
            Col.blue = 0;
            name = "T";
        }
    }
}
//---------------------------------------------------