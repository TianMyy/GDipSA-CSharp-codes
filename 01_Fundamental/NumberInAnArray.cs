using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Github
{
    class NumberInAnArray
    {
		static void Main()
		{
			int[,] theArray = new int[,]
			{
				{5,3},{2,9},{2,9},
				{5,1},{7,1},{2,9},
				{0,3},{2,2},{9,7}
			};

			int count = 0;
			Console.Write("Please enter a number(0-9): ");
			int input = int.Parse(Console.ReadLine());
			foreach (int i in theArray)
			{
				if (i == input)
					count++;
			}
			Console.WriteLine("The number of {0} is {1}", input, count);

		}
	}
}
