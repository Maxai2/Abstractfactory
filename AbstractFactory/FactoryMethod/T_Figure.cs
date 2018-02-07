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
            figArr = new int[4, 4] { { 0, 1, 0, 0 }, { 1, 1, 1, 0 }, { 0, 0, 0, 0 }, { 0, 0, 0, 0 } };
        }
    }
}
//---------------------------------------------------