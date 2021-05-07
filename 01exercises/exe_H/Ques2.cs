using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyExerciseEFGH.Exercise_H
{
    class Ques2
    {
        static void Main()
        {
            Console.Write("How many integers in your array: ");
            int num = int.Parse(Console.ReadLine());
            int[] input = new int[num];
            Console.WriteLine("Enter your integer: ");
            for (int i = 0; i < input.Length; i++)
                input[i] = int.Parse(Console.ReadLine()); ;
            PrintArray(input);
        }
       public static void PrintArray(int[] arr)
        {
            Console.Write("Your array is ");
            for(int i = 0; i < arr.Length; i++)
                Console.Write(arr[i]+" ");
        }
    }
}
