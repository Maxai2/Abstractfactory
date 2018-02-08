using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//---------------------------------------------------
namespace FactoryMethod
{
    class L_FigureBuilder : FigureBuilder
    {
        Figure FigureBuilder.Create() => new L_Figure();
    }
}
//---------------------------------------------------