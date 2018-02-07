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
            figArr = new int[4, 4] { { 1, 0, 0, 0 }, { 1, 0, 0, 0 }, { 1, 0, 0, 0 }, { 1, 0, 0, 0 } };
        }
    }
}
//---------------------------------------------------