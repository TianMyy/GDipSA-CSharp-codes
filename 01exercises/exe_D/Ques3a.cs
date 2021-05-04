using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyExercise.ExerciseD
{
    class Ques3a
    {
        static void Main()
        {
            Random rnd = new Random();
            int secret = rnd.Next(0, 10);
            Console.Write("Enter an integer: ");
            int input = int.Parse(Console.ReadLine());
            int count = 1;
            while (input != secret)
            {
                Console.Write("incorrect,try again: ");
                input = int.Parse(Console.ReadLine());
                count++;
            }
            Console.WriteLine("Congratulate, you try {0} times",count);
        }
    }
}
//I wrote at first time:
//Random rnd = new Random();
//int secret = rnd.Next(0, 10);
//Console.Write("Please guess (0-9): ");
//int guess = int.Parse(Console.ReadLine());
//int i;
//for (i = 1; guess != secret; i++)
//{
//    Console.Write("Try again\nPlease guess (0-9): ");
//    guess = int.Parse(Console.ReadLine());
//}
//Console.WriteLine("Congratulate! You took {0} attempts.", i);
