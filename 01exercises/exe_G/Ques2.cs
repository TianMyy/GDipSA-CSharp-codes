using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace MyExerciseEFGH.Exercise_G
{
    class Ques2
    {
        static void Main()
        {
            int[] number = new int[8] { 14, 6, 8, 19, 32, 40, 11, 2 };
            for(int i = 0;i < number.Length-1; i++)
            {
                for (int j = 0; j < number.Length-1-i;j++)
                {
                    if (number[j] < number[j+1])
                    {
                        int temp = number[j];
                        number[j] = number[j + 1];
                        number[j + 1] = temp;
                    }
                }
                for (int n = 0; n < number.Length; n++)
                    Console.Write("{0}\t", number[n]);
                Console.WriteLine("");
            }
        }
    }
}
