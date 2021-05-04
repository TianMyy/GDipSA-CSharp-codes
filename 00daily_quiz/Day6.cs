using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayQuiz
{
	class Day6
	{
		static int[] minIncomeArray = new int[]
			{ 20000, 30000, 40000, 80000,
			  120000, 160000, 200000, 320000 };
		static double[] taxRateArray = new double[]
			{ 0.02, 0.035, 0.07, 0.115,
			  0.15, 0.17, 0.18, 0.20 };
		static int[] basePayableAmountArray = new int[]
			{ 0, 200, 550, 3350,
			  7950, 13950, 20750, 42350 };

		static void Main(string[] args)
		{
			int annualIncome = AskForIncome();
			int taxBracket = GetTaxBracket(annualIncome);
			double taxPayable =
				CalculateIncomeTax(annualIncome, taxBracket);
			PrintResult(annualIncome, taxPayable);
		}
		static int AskForIncome()
		{
			Console.Write("Please enter your annual taxable income:");
			return int.Parse(Console.ReadLine());
		}
		static int GetTaxBracket(int income)
		{
			if (income < 20000)
				return -1;
			if (income >= 20000 && income < 30000)
				return 0;
			if (income >= 30000 && income < 40000)
				return 1;
			if (income >= 40000 && income < 80000)
				return 2;
			if (income >= 80000 && income < 120000)
				return 3;
			if (income >= 120000 && income < 160000)
				return 4;
			if (income >= 160000 && income < 200000)
				return 5;
			if (income >= 200000 && income < 320000)
				return 6;
			else
				return 7;
		}
		static double CalculateIncomeTax(int income, int index)
		{
			if (index == -1)
				return 0;
			else
				return (income - minIncomeArray[index]) * taxRateArray[index] + basePayableAmountArray[index];
		}
		static void PrintResult(int income, double tax)
		{
			Console.WriteLine("For taxable annual income of ${0:#,##0.00},the tax payable amount is ${1:#,##0.00}", income, tax);
		}
	}
}
