using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp
{
    class VisaAccount: Account
    {
        private double CreditLimit;
        public double INTEREST_RATE = 0.1995;

        public VisaAccount(double balance = 0, double creditLimit = 1200)
            : base("VS", balance)
        {
            this.Balance = balance;
            CreditLimit = creditLimit;
  
        }
        public void DoPayment(double amount, Person person)
        {
            base.Deposit(amount, person);
        }
        public void DoPurchase(double amount, Person person)
        {
            if ( amount <= CreditLimit)
            {
                base.Deposit(-amount, person);
            }

        }
        public override void PrepareMonthlyReport()
        {
            double interestCharge = (base.LowestBalance * INTEREST_RATE) / 12;
            base.Balance -= interestCharge;
            transactions.Clear();
        }

    }
}
