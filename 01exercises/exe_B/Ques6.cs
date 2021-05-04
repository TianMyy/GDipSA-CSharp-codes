using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyExercise.ExerciseB
{
    class Ques6
    {
        static void Main()
        {
			Console.Write("Enter the value of X1: ");
			double x1 = double.Parse(Console.ReadLine());
			Console.Write("Enter the value of Y1: ");
			double y1 = double.Parse(Console.ReadLine());
			Console.Write("Enter the value of X2: ");
			double x2 = double.Parse(Console.ReadLine());
			Console.Write("Enter the value of Y2: ");
			double y2 = double.Parse(Console.ReadLine());

			double distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
			Console.WriteLine("The distance of two points is:{0}", distance);
		}
    }
}
