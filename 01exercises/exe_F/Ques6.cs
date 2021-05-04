using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyExerciseEFGH.Exercise_F
{
    class Ques6
    {
        static void Main()
        {
            Console.Write("Enter a matriculation number: ");
            string input = Console.ReadLine();
            int length = input.Length;
            string use = input.ToUpper();
            if (length == 7)
            {
                int sum = 0;
                string check = null;
                int n = 6;
                for (int i = 1;i <= 5;i++)
                {
                    sum += int.Parse(use.Substring(i,1)) * n;
                    n--;
                }
                if (sum % 5 == 0)
                    check = "O";
                if (sum % 5 == 1)
                    check = "P";
                if (sum % 5 == 2)
                    check = "Q";
                if (sum % 5 == 3)
                    check = "R";
                if (sum % 5 == 4)
                    check = "S";

                if (check == use.Substring(6,1))
                    Console.WriteLine("Valid");
                else
                    Console.WriteLine("Invalid");
            }
            else
                Console.WriteLine("Invalid");
        }
    }
}
