using System;
using System.Collections.Generic;
using System.Text;

namespace UpDownCasting
{
    class SavingsAccount : Account
    {
        public double InterestRage { get; set; }

        public SavingsAccount()
        {

        }

        public SavingsAccount(int number, string holder, double balance, double intrestRage) : base(number, holder, balance)
        {
            InterestRage = intrestRage;
        }


        public void UpdateBalance()
        {
            Balance += Balance * InterestRage;
        }
    }
}
