using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayQuiz
{
    class Day4
    {
		static void Main()
		{
			Console.Write("Welcome to the bank of ISS\nEnter your PIN: ");
			string pin = Console.ReadLine();
			string right = "123456";
			int num = 0;
			do
			{
				Console.WriteLine("Enter your PIN: ");
				num++;
				if (pin == right)
				{
					Console.WriteLine("PIN accepted.You can access your account now.");
				}
				if (pin != right && num < 3)
				{
					Console.Write("Incorrect PIN.Please try again.");
				}
			} while (num < 3 && pin != right);
			if (pin != right && num >= 3)
				Console.WriteLine("Too many wrong PIN entries. Your account is now locked.");

		}
	}
}
