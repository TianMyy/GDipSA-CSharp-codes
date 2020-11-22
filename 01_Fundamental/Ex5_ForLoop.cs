using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Github
{
    class Ex5_ForLoop
    {
        static void Main()
        {
            //Ques1
            Console.Write("Enter your number: ");
            int num = int.Parse(Console.ReadLine());
            int fac = 1;
            for (int i = 2; i <= num; i++)
            {
                fac = fac * i;
            }
            Console.WriteLine("Output:{0}", fac);
            Console.WriteLine("--------------------");
            int fac2 = num;
            for (int j = (num - 1); j >= 1; j--)
            {
                fac2 = fac2 * j;
            }
            Console.WriteLine("Output2:{0}", fac2);
            Console.WriteLine();

            //Ques2
            Console.WriteLine("NO\tINVERSE\tSQUARE ROOT\tSQUARE");
            Console.WriteLine("------------------------------");
            for (int i = 1; i < 11; i++)
            {
                double inverse = 1.0 / i;
                double sqrt = Math.Sqrt(i);
                double square = Math.Pow(i, 2);
                Console.WriteLine("{0:0.0}\t{1:0.0##}\t{2:0.0##}\t\t{3:0.0}", i, inverse, sqrt, square);
            }
            Console.WriteLine();

            //Ques3
            Console.Write("Enter your integer: ");
            int number = int.Parse(Console.ReadLine());
            int count2 = 0;
            for (int i = 1; i < number; i++)
            {
                if (number % i == 0)
                    count2++;
            }
            if (count2 == 1)
                Console.WriteLine("Prime");
            else
                Console.WriteLine("Not Prime");
            Console.WriteLine();

            //Ques4
            Console.Write("Enter your integer: ");
            int integer = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i < integer; i++)
            {
                if (integer % i == 0)
                    sum += i;
            }
            if (sum == integer)
                Console.WriteLine("Perfect Number");
            else
                Console.WriteLine("Not Perfect Number");
            Console.WriteLine();

            //Ques5
            for (int i = 5; i <= 10000; i++)
            {
                int count3 = 0;
                for (int j = 1; j < i; j++)
                {
                    if (i % j == 0)
                        count3++;
                }
                if (count3 == 1)
                    Console.WriteLine(i);
            }
            Console.WriteLine();

            //Ques6
            for (int i = 1; i < 1000; i++)
            {
                int sum2 = 0;
                for (int j = 1; j < i; j++)
                {
                    if (i % j == 0)
                        sum2 += j;
                }
                if (sum2 == i)
                    Console.WriteLine(i);
            }
            Console.WriteLine();
        }
    }
}
