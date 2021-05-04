using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyExercise.ExerciseD
{
    class Ques2
    {
		public static void Main()
		{
			Console.Write("Enter the first integer: ");
			int A = int.Parse(Console.ReadLine());
			Console.Write("Enter the second integer: ");
			int B = int.Parse(Console.ReadLine());
			int total = A * B;
			while (A != B)
			{
				if (A > B)
                {
					A = A - B;
				}
				if (B > A)
                {
					B = B - A;
				}
			}
			int HCF = A;
			int LCM = total / HCF;
			Console.WriteLine("HCF is {0},LCM is {1}", HCF, LCM);
		}
	}
}
