using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MyExerciseEFGH.Exercise_H
{
    class Ques7
    {
        static void Main()
        {
            for(int i = 5; i <= 1000; i++)
            {
                if (IsPrime(i) == true)
                    Console.WriteLine("{0} is a Prime",i);
            }
        }
        public static Boolean IsPrime(int n)
        {
            int count = 0;
            for(int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                    count++;
            }
            if (count == 2)
                return true;
            else
                return false;
        }
    }
}
