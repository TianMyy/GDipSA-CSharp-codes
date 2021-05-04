using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyExerciseEFGH.Exercise_F
{
    class Ques4
    {
        static void Main()
        {
            Console.Write("Enter your phrase or sentence: ");
            string input = Console.ReadLine();
            string[] arr = input.Split(' ');
            int length = arr.Length;
            string a = "";
            for (int i = 0;i < length;i++)
            {
                a += arr[i].Substring(0, 1).ToUpper() + arr[i].Substring(1) + " ";
            }
            Console.WriteLine(a);
        }
    }
}
