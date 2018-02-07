using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//---------------------------------------------------
namespace FactoryMethod
{
    class J_Figure : Figure
    {
        //205,133,63 Peru
        public J_Figure()
        {
            figArr = new int[4, 4] { { 1, 1, 1, 1 }, { 1, 0, 0, 0 }, { 0, 0, 0, 0 }, { 0, 0, 0, 0 } };
            name = "J";
            Col.red = 205;
            Col.green = 133;
            Col.blue = 63;
        }
    }
}
//---------------------------------------------------