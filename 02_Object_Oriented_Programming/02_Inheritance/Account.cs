using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyOopCode_2._02_Inheritance
{
    public class Account
    {
        private string acctNumber;
        private string acctHolderId;
        private double balance;
        public Account() { }
        public Account(string acctNumber,string acctHolderId,double balance)
        {
            AcctNumber = acctNumber;
            AcctHolderId = acctHolderId;
            Balance = balance;
        }
        public string AcctNumber
        {
            get { return acctNumber; }
            set { acctNumber = value; }
        }
        public string AcctHolderId
        {
            get { return acctHolderId; }
            set { acctHolderId = value; }
        }
        public double Balance
        {
            get { return balance; }
            set { balance = value; }
        }
        public virtual double CalculateInterest()
        {
            return balance * 0;
        }
        public virtual void CreditInterest()
        {
            Deposit(CalculateInterest());
        }
        public double Deposit(double amount)
        {
            balance += amount;
            return balance;
        }
        public virtual bool Withdraw(double amount)
        {
            if (amount <= balance)
            {
                balance -= amount;
                return true;
            }
            else
                return false;
        }
        public void TransferTo(double amount,Account another)
        {
            if (Withdraw(amount) == true)
            {
                balance -= amount;
                another.Balance += another.Deposit(amount);
            }
        }
        public override string ToString()
        {
            return string.Format("Account: accountNumber={0}, accountHolder={1}, balance={2}", AcctNumber, AcctHolderId, Balance);
        }
    }
}
