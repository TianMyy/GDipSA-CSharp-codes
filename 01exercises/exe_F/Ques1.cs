using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyExerciseEFGH.Exercise_F
{
    class Ques1
    {
        static void Main()
        {
            Console.Write("Enter you phrase: ");
            string input = Console.ReadLine();
            int count = 0;
            for (int i = 0;i < input.Length;i++)
            {
                string s = input.Substring(i,1);
                if (s == "a" ||s == "e"||s == "i"||s == "o"||s == "u")
                {
                    count++;
                }
            }
            Console.WriteLine("There are {0} vowels",count);
            Console.WriteLine("--------------------");

            Console.Write("Enter your phrase: ");
            string input2 = Console.ReadLine();
            int counta = 0, counte = 0, counti = 0, counto = 0, countu = 0;
            for (int n = 0;n < input2.Length;n++)
            {
                string str = input2.Substring(n, 1);
                if (str == "a")
                    counta++;
                if (str == "e")
                    counte++;
                if (str == "i")
                    counti++;
                if (str == "o")
                    counto++;
                if (str == "u")
                    countu++;
            }
            Console.WriteLine("The appearance of \"a\" is {0},\"e\" is {1},\"i\" is {2},\"o\" is {3},\"u\" is {4}",counta,counte,counti,counto,countu);
        }
    }
}
