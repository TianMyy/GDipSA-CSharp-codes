using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayQuiz
{
    class Day3
    {
        static void Main()
        {
            Console.Write("Welcome to ISS Gadget Shop\nNumber of items to purchase: ");
            double num = double.Parse(Console.ReadLine());
            double amount = num * 500;
            if (amount > 2000 && amount <= 3000)
            {
                amount = amount * 0.97;
            }
            if (amount > 3000 && amount <= 6000)
            {
                amount = amount * 0.95;
            }
            if (amount > 6000)
            {
                amount = amount * 0.92;
            }

            Console.WriteLine("Please pay ${0:0.00}", amount);
        }
    }
}
