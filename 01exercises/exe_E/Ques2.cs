using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyExerciseEFGH.Exercise_E
{
    class Ques2
    {
        static void Main()
        {
            for(double i = 1.0;i <= 10.0;i++)
            {
                double inverse = 1.0 / i;
                double sqrt = Math.Sqrt(i);
                double square = Math.Pow(i, 2);
                Console.WriteLine("{0:0.0}\t{1:0.###}\t{2:0.###}\t{3:0.0}",i,inverse,sqrt,square);
            }
        }
    }
}
