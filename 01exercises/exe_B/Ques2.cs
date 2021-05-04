using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyExercise.ExerciseB
{
    class Ques2
    {
		static void Main()
		{
			Console.Write("Enter a double precision number: ");
			double input = double.Parse(Console.ReadLine());
			Console.WriteLine("Square root:{0:0.000}", Math.Sqrt(input));
		}
	}
}
