using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_DataStructure._05_Sort
{
    class Bubble
    {
        static void Main()
        {
            int[] number = new int[6] { 4, 3, 5, 6, 2, 1 };
            for (int i = 0; i < number.Length - 1; i++)
            {
                for (int j = 0; j < number.Length - 1 - i; j++)
                {
                    if (number[j] > number[j + 1])
                    {
                        int temp = number[j];
                        number[j] = number[j + 1];
                        number[j + 1] = temp;
                    }
                }
                for (int a = 0; a < number.Length; a++)
                    Console.Write("{0}\t", number[a]);
                Console.WriteLine();
            }
        }
    }
}
