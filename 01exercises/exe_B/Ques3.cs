using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyExercise.ExerciseB
{
    class Ques3
    {
		static void Main()
		{
			Console.Write("Enter your salary: ");
			double salary = double.Parse(Console.ReadLine());
			double house = 0.1 * salary;
			double transport = 0.03 * salary;
			double total = salary + house + transport;
			Console.WriteLine("Total income:${0:#,000.00}", total);
		}
	}
}
