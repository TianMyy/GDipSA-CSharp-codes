using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyExercise.ExerciseC
{
    class Ques3
    {
		static void Main()
		{
			Console.Write("Enter your mark: ");
			int mark = int.Parse(Console.ReadLine());

			if (mark >= 80 && mark <= 100)
				Console.WriteLine("You scored {0} marks which is A grade", mark);
			if (mark >= 60 && mark < 80)
				Console.WriteLine("You scored {0} marks which is B grade", mark);
			if (mark >= 40 && mark < 60)
				Console.WriteLine("You scored {0} marks which is C grade", mark);
			if (mark >= 0 && mark < 40)
				Console.WriteLine("You scored {0} marks which is F grade", mark);
			if (mark < 0 || mark > 100) 
				Console.WriteLine("**Error**");
		}
	}
}
