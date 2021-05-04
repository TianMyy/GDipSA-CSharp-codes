using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyExerciseEFGH.Exercise_E
{
    class Ques6
    {
        static void Main()
        {
            for(int input = 1; input <= 1000;input++)
            {
                int sum = 0;
                for (int i = 1; i < input; i++)
                {
                    if (input % i == 0)
                        sum += i;
                }
                if (sum == input)
                    Console.WriteLine(input);
            }
        }
    }
}
