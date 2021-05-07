using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyExerciseEFGH.Exercise_H
{
    class Ques3
    {
        static void Main()
        {
            for (int i = 0; i < 100; i++)
                Console.Write(ReturnHex(i) + " ");
        }
        public static string ReturnHex(int a)
        {
            //0-9来表示十六进制中的0-9；A-F来表示十六进制中的10-15；
            string[] sixteen = new string[16] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "A", "B", "C", "D", "E", "F" };
            int c = a / 16;
            string s1 = sixteen[c];
            int remain = a % 16;
            string s2 = sixteen[remain];
            if (a < 16)
                return s2;
            else
                return s1 + s2;
        }

        //public static string Hex(int i)
        //{
        //    char[] hexChars = new char[]
        //    {'0', '1', '2', '3', '4',
        //     '5', '6', '7', '8', '9',
        //     'A', 'B', 'C', 'D', 'E', 'F' };

        //    string hex = "";

        //    do
        //    {
        //        int remainder = i % 16;
        //        hex = hexChars[remainder] + hex;

        //        i = i / 16;

        //    } while (i > 0);

        //    return hex;
        //}

        //static void Main()
        //{
        //    for (int i = 0; i <= 100; i++)
        //    {
        //        Console.WriteLine(Hex(i));
        //    }
        //}
    }
}

