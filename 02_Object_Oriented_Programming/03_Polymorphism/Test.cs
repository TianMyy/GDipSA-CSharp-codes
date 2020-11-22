using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyOopCode_2._02_Inheritance;

namespace MyOopCode_2._03_Polymorphism
{
    class Test
    {
        static void Main()
        {
            SavingsAccount saving = new SavingsAccount("0001", "S01A", 2000);
            Console.WriteLine(saving.ToString());
            CurrentAccount current = new CurrentAccount("0002", "S02A", 2000);
            Console.WriteLine(current.ToString());
            OverdraftAccount over1 = new OverdraftAccount("0003", "S03A", 2000);
            Console.WriteLine(over1.ToString());
            OverdraftAccount over2 = new OverdraftAccount("0001", "S01A", -2000);
            Console.WriteLine(over2.ToString());
            Console.WriteLine();

            BankBranch branch = new BankBranch("TIAN TIAN");
            branch.AddAccount(saving);
            branch.AddAccount(current);
            branch.AddAccount(over1);
            branch.AddAccount(over2);

            Console.WriteLine("Print all accounts: ");
            branch.PrintAccounts();
            Console.WriteLine();

            Console.WriteLine("Print total deposit:{0}", branch.TotalDeposits());
            Console.WriteLine("Print total interestpaid:{0}", branch.TotalInterestPaid());
            Console.WriteLine("Print total interestearned:{0}", branch.TotalInterestEarned());
            Console.WriteLine();

            Console.WriteLine("Print all customers: ");
            branch.PrintCustomers();
        }
    }
}
