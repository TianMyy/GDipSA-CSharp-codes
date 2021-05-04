using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyExercise.ExerciseC
{
    class Ques1
    {
		static void Main()
		{
			Console.Write("Enter your name: ");
			string name = Console.ReadLine();
			Console.Write("Enter your gender(M or F): ");
			string gender = Console.ReadLine();

			if (gender == "M")
				Console.WriteLine("Good Morning Mr.{0}", name);
			else if (gender == "F")
				Console.WriteLine("Good Morning Ms.{0}", name);
		}
	}
}
