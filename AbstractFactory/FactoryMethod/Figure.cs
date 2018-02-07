using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//---------------------------------------------------
namespace FactoryMethod
{
    struct FigureCol
    {
        public byte red;
        public byte green;
        public byte blue;
    }

    abstract class Figure
    {
        protected int[,] figArr;
        protected FigureCol Col;
        protected string name;
    }
}
//---------------------------------------------------