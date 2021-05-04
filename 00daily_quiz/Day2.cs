using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayQuiz
{
    class Day2
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter the length in cm: ");
            double cm = double.Parse(Console.ReadLine());
            Console.Write("{0:0.000}", cm / 2.54);
        }
    }
}
