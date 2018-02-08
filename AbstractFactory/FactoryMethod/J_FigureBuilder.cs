using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//---------------------------------------------------
namespace FactoryMethod
{
    class J_FigureBuilder : FigureBuilder
    {
        Figure FigureBuilder.Create() => new J_Figure();
    }
}
//---------------------------------------------------