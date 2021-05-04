using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyExercise.ExerciseA
{
	class Ques5
	{
		static void Main()
		{
			Console.Write("Please enter a double precision number: ");
			double input = double.Parse(Console.ReadLine());
			Console.WriteLine("Output:{0:0.00}", input);
		}
	}
}