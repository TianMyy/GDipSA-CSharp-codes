using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace MyExercise.ExerciseB
{
    class Ques10
    {
		static void Main()
		{
			Console.Write("Enter the value of side1: ");
			double a = double.Parse(Console.ReadLine());
			Console.Write("Enter the value of side2: ");
			double b = double.Parse(Console.ReadLine());
			Console.Write("Enter the value of side3: ");
			double c = double.Parse(Console.ReadLine());
			double s = (a + b + c) / 2;

			if (s == 0)
                Console.WriteLine(s);
			else if ((b+c)>a && (a+c)>b && (a+b)>c)
            {
				double area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));
				Console.WriteLine("The area of this triangle is:{0}", area);
            }
			else
                Console.WriteLine("NaN");
		}
	}
}
