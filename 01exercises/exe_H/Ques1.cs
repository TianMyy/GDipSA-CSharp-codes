using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace MyExerciseEFGH.Exercise_H
{
    class Ques1
    {
        static void Main()
        {
            int input = ReadInteger("Please enter X: ");
            Console.WriteLine(input);
        }
        public static int ReadInteger(string message)
        {
            Console.Write(message);
            int output = 0;
            //要给boolean一个默认值
            bool integer = false;
            while (integer == false)
            {
                integer = Int32.TryParse(Console.ReadLine(), out output);
                if (integer == false)
                    Console.Write("Your enter is not an integer.\nEnter again: ");
            }

            return output;
        }
        //static int ReadInteger(string message)
        //{
        //    Console.Write(message);
        //    int output;
        //    bool isParsable = false;

        //    do
        //    {
        //        isParsable = Int32.TryParse(Console.ReadLine(), out output);


        //        if (!isParsable)
        //        {
        //            Console.WriteLine("Your input is not an integer.");
        //        }
        //    } while (!isParsable);

        //    return output;
        //}

        //static void Main(string[] args)
        //{
        //    int x = ReadInteger("Please enter x: ");
        //    Console.WriteLine(x);
        //}
    }
}
