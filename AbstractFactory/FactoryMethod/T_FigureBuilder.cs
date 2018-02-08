using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//---------------------------------------------------
namespace FactoryMethod
{
    class T_FigureBuilder : FigureBuilder
    {
        Figure FigureBuilder.Create() => new T_Figure();
    }
}
//---------------------------------------------------