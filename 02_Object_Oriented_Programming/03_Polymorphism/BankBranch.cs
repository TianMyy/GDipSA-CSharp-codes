using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyOopCode_2._02_Inheritance;

namespace MyOopCode_2._03_Polymorphism
{
    public class BankBranch
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        List<Account> accounts;
        public BankBranch(string name)
        {
            Name = name;
            accounts = new List<Account>();
        }
        public void AddAccount(Account a)
        {
            accounts.Add(a);
        }
        public void PrintAccounts()
        {
            foreach (Account ele in accounts)
                Console.WriteLine(ele.ToString());
        }
        public double TotalDeposits()
        {
            double sum = 0;
            foreach(Account ele in accounts)
            {
                if (ele.Balance >= 0)
                    sum += ele.Balance;
            }
            return sum;
        }
        public double TotalInterestPaid()
        {
            double sum = 0;
            foreach(Account ele in accounts)
            {
                if (ele.Balance >= 0)
                    sum += ele.CalculateInterest();
            }
            return sum;
        }
        public double TotalInterestEarned()
        {
            double sum = 0;
            foreach(Account ele in accounts)
            {
                if (ele.Balance < 0)
                    sum -= ele.CalculateInterest();
            }
            return sum;
        }
        public void PrintCustomers()
        {
            List<string> holderId = new List<string>();
            foreach (Account ele in accounts)
            {
                if (!holderId.Contains(ele.AcctHolderId))
                    holderId.Add(ele.AcctHolderId);
            }
            for (int i = 0; i < holderId.Count; i++)
                Console.WriteLine(holderId[i]);
        }
    }
}
