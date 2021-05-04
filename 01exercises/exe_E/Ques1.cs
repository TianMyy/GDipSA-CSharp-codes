using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyExerciseEFGH.Exercise_E
{
    class Ques1
    {
        static void Main()
        {
            Console.Write("Enter an integer: ");
            int num = int.Parse(Console.ReadLine());
            int b = 1;
            for (int a = 2;a <= num; a++)
            {
                b = b * a;
            }
            Console.WriteLine("Factorial:{0}",b);
            Console.WriteLine("--------------------");

            Console.Write("Enter an integer: ");
            int num2 = int.Parse(Console.ReadLine());
            for (int c = (num2-1);c >= 1;c--)
            {
                num2 = num2 * c;
            }
            Console.WriteLine("Factorial:{0}",num2);
        }
    }
}
