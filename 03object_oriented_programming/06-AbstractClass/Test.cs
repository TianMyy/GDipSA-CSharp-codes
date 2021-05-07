using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyOopCode_2._06_AbstractClass
{
    class Test
    {
        static void Main()
        {
            Rectangle rec = new Rectangle(4, 5);
            Console.WriteLine("Area is:{0}", rec.Area());
            Triangle tri = new Triangle(4, 5);
            Console.WriteLine("Area is:{0}", tri.Area());
            Circle cir = new Circle(4);
            Console.WriteLine("Area is:{0}", cir.Area());
        }
    }
}
