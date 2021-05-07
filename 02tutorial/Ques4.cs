using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial_1026
{
    class Ques4
    {
        static void Main()
        {
            int input = ReadInteger("Enter your integer: ");
            Console.WriteLine(input);
        }
        public static int ReadInteger(string s)
        {
            Console.Write(s);
            int output = 0;
            bool isInteger = false;
            while(isInteger == false)
            {
                isInteger = int.TryParse(Console.ReadLine(), out output);
                if (isInteger == false)
                    Console.Write("Your number is incorrect.\nTry again: ");
            }
            return output;
        }
    }
}
