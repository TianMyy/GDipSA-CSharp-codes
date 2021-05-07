using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyExerciseEFGH.Exercise_H
{
    class Ques6
    {
        static void Main()
        {
            int[] A = new int[] { 1, 2, 3, 4, 5 };
            PrintArray(A);

            int[] B = ResizeArray(A, 10);
            PrintArray(B);

            int[] C = ResizeArray(B, 3);
            PrintArray(C);
        }
        public static int[] ResizeArray(int[] arr, int newsize)
        {
            int[] newarray = new int[newsize];
            //int limit = Math.Min(array.Length, newsize); //coz the newsize may not be always bigger than array.Length
            if (newsize > arr.Length)
            {
                for (int i = 0; i < arr.Length; i++)
                    newarray[i] = arr[i];
            }
            else
                for (int i = 0; i < newsize; i++)
                    newarray[i] = arr[i];

            return newarray;
        }
        public static void PrintArray(int[] arr)
        {
            Console.Write("Your array is ");
            for (int i = 0; i < arr.Length; i++)
                Console.Write(arr[i] + " ");
        }
    }
}
