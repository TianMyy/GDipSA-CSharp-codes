using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyExerciseEFGH.Exercise_E
{
    class Ques4
    {
        static void Main()
        {
            Console.Write("Enter an integer number: ");
            int input = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 1;i < input;i++)
            {
                if (input % i == 0)
                    sum += i;
            }
            if (sum == input)
                Console.WriteLine("Perfect Number");
            else
                Console.WriteLine("Not Perfect Number");
        }
    }
}
