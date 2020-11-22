using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Github
{
    class Ex1_InputOutput
    {
        static void Main(string[] args)
        {
            //Ques1
            Console.WriteLine("John Smith");
            Console.WriteLine("e0011223@u.nus.edu");
            Console.WriteLine();

            //Ques2
            Console.Write("Enter you rname: ");
            string name = Console.ReadLine();
            Console.WriteLine("Good Morning {0}", name);
            Console.WriteLine();

            //Ques3
            Console.Write("Enter your integer: ");
            int input = int.Parse(Console.ReadLine());
            Console.WriteLine("Output:{0}", Math.Pow(input, 2));
            Console.WriteLine();

            //Ques4
            Console.Write("Enter your double precision number: ");
            double num = double.Parse(Console.ReadLine());
            Console.WriteLine("Output:{0}", Math.Pow(num, 2));
            Console.WriteLine();

            //Ques5
            Console.Write("Enter your double precision number: ");
            double number = double.Parse(Console.ReadLine());
            Console.WriteLine("Output:{0:0.00}", number);
        }
    }
}
