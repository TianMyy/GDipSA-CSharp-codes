using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyExercise.ExerciseC
{
    class Ques2
    {
		static void Main()
		{
			Console.Write("Enter your name: ");
			string name = Console.ReadLine();
			Console.Write("Enter your gender(M or F): ");
			string gender = Console.ReadLine();
			Console.Write("Enter your age: ");
			int age = int.Parse(Console.ReadLine());
			if (age > 0 && age < 40)
			{
				if (gender == "M")
					Console.WriteLine("Good Morning Mr.{0}", name);
				else if (gender == "F")
					Console.WriteLine("Good Morning Ms.{0}", name);
			}
			if (age >= 40)
			{
				if (gender == "M")
					Console.WriteLine("Good Morning Uncle {0}", name);
				else if (gender == "F")
					Console.WriteLine("Good Morning Aunty {0}", name);
			}
		}
	}
}
