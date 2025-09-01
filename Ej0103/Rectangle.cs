using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej0103
{
    internal class Rectangle (double width, double heigth) : IShape
    {
        public double GetArea() => width * heigth;

        public string GetName() => "Rectangle";
    }
}
