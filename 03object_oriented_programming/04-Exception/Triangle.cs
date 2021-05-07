using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyOopCode_2._04_Exception
{
    public class Triangle
    {
        double side1;
        double side2;
        double side3;
        public double Side1 { get; set; }
        public double Side2 { get; set; }
        public double Side3 { get; set; }
        public Triangle(double side1, double side2, double side3)
        {
            if (isValid(side1, side2, side3))
            {
                Side1 = side1;
                Side2 = side2;
                Side3 = side3;
            }
            else
                throw new BadTriangleException("Invalid Sides");
        }
        public bool isValid(double a, double b, double c)
        {
            if (a > 0 && b > 0 && c > 0 &&
                a + b > c && a + c > b && c + b > a)
                return true;
            else
                return false;
        }
        public double Perimeter()
        {
            return Side1 + Side2 + Side3;
        }
        public double Area()
        {
            double p = Perimeter() / 2;
            return Math.Sqrt(p * (p - Side1) * (p - Side2) * (p - Side3));
        }
    }
}
