using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej0103
{
    internal class Circle : IShape
    {
        double Radius;

        public Circle(double radius) => Radius = radius;

        public double GetArea() => Math.PI * Radius * Radius;

        public string GetName() => "Circle";
    }
}
