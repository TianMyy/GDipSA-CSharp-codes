using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyExerciseEFGH.Exercise_E
{
    class Ques5
    {
        static void Main()
        {
            for (int input = 5;input <= 10000;input++)
            {
                int count = 0;
                for (int i = 1; i < input; i++)
                {
                    if (input % i == 0)
                        count++;
                } 
                if (count == 2)
                    Console.WriteLine(input);
            }
        }
    }
}
