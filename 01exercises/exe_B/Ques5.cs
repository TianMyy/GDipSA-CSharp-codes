using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyExercise.ExerciseB
{
    class Ques5
    {
		static void Main()
		{
			Console.Write("Enter the value of X: ");
			double x = double.Parse(Console.ReadLine());
			double y = 5 * Math.Pow(x, 2) - 4 * x + 3;
			Console.WriteLine("The value of Y:{0}", y);
		}
	}
}
