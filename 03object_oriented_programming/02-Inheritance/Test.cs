using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyOopCode_2._02_Inheritance
{
    class Test
    {
        static void Main()
        {
            //Account account1 = new Account("S0000111", "S1111111A", 2000);
            //Console.WriteLine(account1.ToString());
            //account1.Deposit(200);
            //Console.WriteLine(account1.ToString());
            //account1.Withdraw(200);
            //Console.WriteLine(account1.ToString());
            //account1.Withdraw(4000);
            //if (account1.Withdraw(4000) == true)
            //    Console.WriteLine("withdraw successfully");
            //if (account1.Withdraw(4000) == false)
            //    Console.WriteLine("Withdraw failed");

            //test account
            Account acct1 = new Account("0001", "S01A", 2000);
            Account acct2 = new Account("0002", "S02A", 2000);
            Console.WriteLine(acct1.ToString());
            Console.WriteLine(acct2.ToString());
            acct1.Deposit(200);
            Console.WriteLine(acct1.ToString());
            acct1.Withdraw(1800);
            Console.WriteLine(acct1.ToString());
            Console.WriteLine(acct1.Withdraw(4000));
            acct1.TransferTo(400, acct2);
            Console.WriteLine(acct2.ToString());
            Console.WriteLine();

            //test savingsaccount
            SavingsAccount saving1 = new SavingsAccount("003", "S03A", 2000);
            Console.WriteLine(saving1.ToString());
            Console.WriteLine("Interest:{0}", saving1.CalculateInterest());
            saving1.CreditInterest();
            Console.WriteLine(saving1.ToString());
            if (saving1.Withdraw(3000) == true)
                Console.WriteLine("Withdraw 3000 is OK.");
            else
                Console.WriteLine("Withdraw 3000 fails.");
            Console.WriteLine();

            //test currentaccount
            CurrentAccount current1 = new CurrentAccount("004", "S04A", 2000);
            Console.WriteLine(current1.ToString());
            Console.WriteLine("Interest:{0}", current1.CalculateInterest());
            current1.CreditInterest();
            Console.WriteLine(current1.ToString());
            current1.Deposit(2000);
            Console.WriteLine(current1.ToString());
            current1.TransferTo(600, saving1);
            Console.WriteLine(current1.ToString());
            Console.WriteLine(saving1.ToString());
            Console.WriteLine();

            //test overdraftaccount
            OverdraftAccount over1 = new OverdraftAccount("005", "S05A", 2000);
            Console.WriteLine(over1.ToString());
            Console.WriteLine("Interest:{0}", over1.CalculateInterest());
            over1.CreditInterest();
            Console.WriteLine(over1.ToString());
            if (over1.Withdraw(3000) == true)
                Console.WriteLine("Withdraw 3000 is OK.");
            else
                Console.WriteLine("Withdraw 3000 fails.");
            Console.WriteLine(over1.ToString());
            Console.WriteLine();

            OverdraftAccount over2 = new OverdraftAccount("006", "S06A", 2000);
            Console.WriteLine(over2.ToString());
            over2.Withdraw(4000);
            Console.WriteLine("Interest:{0}", over2.CalculateInterest());
            over2.CreditInterest();
            Console.WriteLine(over2.ToString());
            Console.WriteLine();
        }
    }
}
