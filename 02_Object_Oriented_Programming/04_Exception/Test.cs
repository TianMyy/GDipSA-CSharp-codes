using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyOopCode_2._04_Exception
{
    class Test
    {
        static void Main()
        {
            try
            {
                Triangle tri1 = new Triangle(3, 4, 5);
                Console.WriteLine("Perimeter is {0}", tri1.Perimeter());
                Console.WriteLine("Area is {0}", tri1.Area());

                Triangle tri2 = new Triangle(1, 1, 5);
                Console.WriteLine("Perimeter is {0}", tri2.Perimeter());
                Console.WriteLine("Area is {0}", tri2.Area());
            }
            catch(BadTriangleException e)
            {
                Console.WriteLine("Sorry.Some exceptions happen.");
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Clean Up");
            }
        }
    }
}
