using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyOopCode_2._02_Inheritance
{
    public class CurrentAccount:Account
    {
        public static double Interest = 0.0025;
        public CurrentAccount(string acctNumber,string acctHolderId,double balance)
            :base(acctNumber,acctHolderId,balance)
        { }
        public override double CalculateInterest()
        {
            return Balance * Interest; 
        }
        public override void CreditInterest()
        {
            base.CreditInterest();
        }
        public override bool Withdraw(double amount)
        {
            return base.Withdraw(amount);
        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
