using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyExercise.ExerciseA
{
	class Ques3
	{
		static void Main()
		{
			Console.Write("Please enter an integer: ");
			int input = int.Parse(Console.ReadLine());
			Console.WriteLine("Square:{0}", Math.Pow(input, 2));
		}
	}
}