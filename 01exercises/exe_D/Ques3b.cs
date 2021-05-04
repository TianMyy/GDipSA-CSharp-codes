using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyExercise.ExerciseD
{
    class Ques3b
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
                Console.Write("Try again,enter an integer: ");
                input = int.Parse(Console.ReadLine());
                count++;
            }
            Console.WriteLine("Congratulate, you try {0} times", count);
            if (count <= 2)
                Console.WriteLine("You are a Wizard!");
            else if (count > 2 && count <= 5)
                Console.WriteLine("You are a good guess!");
            else
                Console.WriteLine("You are lousy!");
        }
    }
}
