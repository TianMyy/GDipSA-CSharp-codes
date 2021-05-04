using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyExercise.ExerciseB
{
    class Ques4
    {
		static void Main()
		{
			Console.Write("Enter a temperature in Centigrade scale: ");
			double centi = double.Parse(Console.ReadLine());
			double fahren = 1.8 * centi + 32;
			Console.WriteLine("Temprature in Fahrenheit:{0}", fahren);
		}
	}
}
