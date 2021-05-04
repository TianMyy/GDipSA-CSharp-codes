using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyExerciseEFGH.Exercise_F
{
    class Ques2
    {
		static void Main()
		{
			Console.Write("Enter your phrase: ");
			string input = Console.ReadLine();
			string use = input.Replace(" ", "");
			string output = "";
			for (int i = (use.Length-1); i >= 0; i--)
			{
				output += use[i];
			}
			if (output == use)
				Console.WriteLine("Palindrome");
			else
				Console.WriteLine("Not Palindrome");
		}
	}
}
