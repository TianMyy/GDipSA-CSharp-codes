using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyExercise.ExerciseC
{
    class Ques4
    {
		static void Main()
		{
			Console.Write("Enter your distance in kilometer: ");
			double input = double.Parse(Console.ReadLine());
			double dis = Math.Ceiling(input * 10) / 10;
			double fee = 0;
			if (dis > 0 && dis <= 0.5)
				fee = 2.40;
			if (dis > 0.5 && dis <= 9)
				fee = 2.40 + (dis - 0.5) * 10 * 0.04;
			if (dis > 9)
				fee = 2.40 + 3.40 + (dis - 9) * 10 * 0.05;
			Console.WriteLine("Total fare is:{0}", fee);
		}
	}
}
