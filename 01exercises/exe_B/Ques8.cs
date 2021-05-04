using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyExercise.ExerciseB
{
    class Ques8
    {
		static void Main()
		{
			Console.Write("Enter your distance: ");
			double dis = double.Parse(Console.ReadLine());
			double fare = Math.Round(2.40 + dis * 0.4, 1);
			Console.WriteLine("The total fare is:{0:0.00}", fare);
		}
	}
}
