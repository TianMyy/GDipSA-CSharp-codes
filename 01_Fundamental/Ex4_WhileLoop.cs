using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Github
{
    class Ex4_WhileLoop
    {
        static void Main()
        {
            //Ques1
            int input = 0;
            do
            {
                Console.Write("Enter your integer: ");
                input = int.Parse(Console.ReadLine());
            }
            while (input != 88);
            Console.WriteLine("Lucky you ...");
            Console.WriteLine();

            //Ques2
            Console.Write("Enter the value of A: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Enter the value of B: ");
            int b = int.Parse(Console.ReadLine());
            int c = a * b;
            Console.WriteLine("A is {0},B is {1}", a, b);
            while (a != b)
            {
                if (a > b)
                    a = a - b;
                if (b > a)
                    b = b - a;
            }
            int hcf = a = b;
            int lcm = c / hcf;
            Console.WriteLine("HCF is {0},LCM is {1}", hcf, lcm);
            Console.WriteLine();

            //Ques3a
            Random rnd = new Random();
            int auto = rnd.Next(0, 10);
            Console.Write("Enter your guess:");
            int guess = int.Parse(Console.ReadLine());
            int i = 1;
            do
            {
                Console.WriteLine("Incorrect.Try again: ");
                guess = int.Parse(Console.ReadLine());
                i++;
            } while (guess != auto);
            Console.WriteLine("Correct, you have try {0} times", i);
            //Ques3b
            if (i <= 2)
                Console.WriteLine("You are a Wizard");
            if (i > 2 && i <= 5)
                Console.WriteLine("You are a good guess");
            else
                Console.WriteLine("You are lousy");
            Console.WriteLine();
        }
    }
}
