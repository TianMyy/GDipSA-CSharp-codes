using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyExerciseEFGH.Exercise_H
{
    class Ques5
    {
        static void Main()
        {
            Console.Write("How long is your array: ");
            int len = int.Parse(Console.ReadLine());
            int[] input = new int[len];
            Console.WriteLine("Enter the int array: ");
            for(int i = 0; i < input.Length; i++)
            {
                input[i] = int.Parse(Console.ReadLine());
            }
            Console.Write("Enter the value you want to assign: ");
            int assign = int.Parse(Console.ReadLine());
            SetArray(input,assign);
        }
        public static void SetArray(int[] arr,int value)
        {
            Console.Write("New array after assign: ");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] += value;
                Console.Write(arr[i]+" ");
            }
        }
    }
}
