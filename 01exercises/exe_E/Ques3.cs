using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyExerciseEFGH.Exercise_E
{
    class Ques3
    {
        static void Main()
        {
            Console.Write("Enter an integer number: ");
            int input = int.Parse(Console.ReadLine());
            int count = 0;
            for(int i = 1; i <= input; i++)
            {
                if (input % i == 0)
                    count++;
            }
            if(count == 2)
                Console.WriteLine("Prime");
            else
                Console.WriteLine("Not Prime");
        }
    }
}
