using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyExercise.ExerciseC
{
    class Ques5
    {
		static void Main()
		{
			Console.Write("Enter a three-digit integer: ");
			int num = int.Parse(Console.ReadLine());
			int bai = num / 100;
			int shi = num % 100 / 10;
			int ge = num % 10;
			double total = Math.Pow(bai, 3) + Math.Pow(shi, 3) + Math.Pow(ge, 3);
			if (total == num)
				Console.WriteLine("True");
			else
				Console.WriteLine("False");
		}
	}
}
