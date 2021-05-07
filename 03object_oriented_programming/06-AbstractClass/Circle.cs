using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyOopCode_2._06_AbstractClass
{
    class Circle:Shape
    {
        double radius;
        public double Radius { get; set; }
        public Circle(double radius)
        {
            Radius = radius;
        }
        public override double Area()
        {
            return Math.PI * Radius * Radius;
        }
    }
}
