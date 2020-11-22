using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyOopCode_2._06_AbstractClass
{
    class Triangle:Shape
    {
        double width;
        double height;
        public double Width { get; set; }
        public double Height { get; set; }
        public Triangle(double width,double height)
        {
            Width = width;
            Height = height;
        }
        public override double Area()
        {
            return 0.5 * Width * Height;
        }
    }
}
