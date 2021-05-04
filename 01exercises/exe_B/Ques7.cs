using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyExercise.ExerciseB
{
    class Ques7
    {
		static void Main()
		{
			Console.Write("Enter your distance: ");
			double dis = double.Parse(Console.ReadLine());
			double fare = 2.40 + dis * 0.4;
			Console.WriteLine("The total fare is:{0}", fare);
		}
	}
}
