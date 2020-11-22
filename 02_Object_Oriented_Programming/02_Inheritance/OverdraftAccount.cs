using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyOopCode_2._02_Inheritance
{
    public class OverdraftAccount:Account
    {
        public static double Interest1 = 0.0025;
        public static double Interest2 = 0.06;
        public OverdraftAccount(string acctNumber,string acctHolderId,double balance)
            :base(acctNumber,acctHolderId,balance)
        { }
        public override double CalculateInterest()
        {
            if (Balance >= 0)
                return Balance * Interest1;
            else
                return Balance * Interest2;
        }
        public override void CreditInterest()
        {
            base.CreditInterest();
        }
        public override bool Withdraw(double amount)
        {
            Balance -= amount;
            return true;
        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
