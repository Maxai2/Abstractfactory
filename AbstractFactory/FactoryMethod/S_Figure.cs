using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//---------------------------------------------------
namespace FactoryMethod
{
    class S_Figure : Figure
    {
        public S_Figure()
        {
            // 0, 153, 51
            figArr = new int[4, 4] { { 0, 1, 1, 0 }, { 1, 1, 0, 0 }, { 0, 0, 0, 0 }, { 0, 0, 0, 0 } };
            Col.red = 0;
            Col.green = 153;
            Col.blue = 51;
            name = "S";
        }
    }
}
//---------------------------------------------------