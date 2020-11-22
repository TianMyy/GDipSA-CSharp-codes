using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyOopCode_2._01_IntegerList
{
    class Test
    {
        static void Main()
        {
            int[] num = { 2, 4, 6, 8, 12, 18, 6, 2, 56, 8 };
            List test = new List(num);

            Console.WriteLine("Sum: {0}", test.Sum());
            Console.WriteLine("Exists: {0}", test.isExist(5));
            Console.WriteLine("Duplicates: {0}", test.Duplicate());
        }
    }
}
