using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyExercise.ExerciseD
{
    class Ques1
    {
		static void Main()
		{
			int input;
			int correct = 88;
			do
			{
				Console.Write("Enter an integer: ");
				input = int.Parse(Console.ReadLine());
			} while (input != correct);
			
			Console.WriteLine("Lucky you...");
		}
	}
}
