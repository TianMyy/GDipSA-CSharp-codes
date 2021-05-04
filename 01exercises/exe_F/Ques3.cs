using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyExerciseEFGH.Exercise_F
{
    class Ques3
    {
		static void Main()
		{
			Console.Write("Enter your phrase: ");
			string input = Console.ReadLine();
			string a = input.ToLower();
			string b = a.Replace(" ", "");
			string c = b.Replace(",", "");
			string use = c.Replace(".", "");
			string output = null;
			for (int i = (use.Length - 1); i >= 0; i--)
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
