using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp
{
    class SavingAccount: Account
    {
        public double COST_PER_TRANSACTION = 0.05;
        public double INTEREST_RATE = 0.015;

        public SavingAccount(double balance = 0)
            : base("SV", balance)
        {
            this.Balance = balance;
        }
        public new void Deposit(double amount, Person person)
        {
            if (IsHolder(person.Name) == true)
            {
                base.Deposit(amount, person);

            }
        }
        public void Withdraw(double amount, Person person)
        {
            if (person.IsAuthenticated)
            {
                if (amount <= this.Balance)
                {
                    base.Deposit(-amount, person);
                }
            }
        }
        public override void PrepareMonthlyReport()
        {
            double serviceCharge = COST_PER_TRANSACTION * base.transactions.Count();
            double interestCharge = (Balance * INTEREST_RATE) / 12;

            base.Balance = (Balance + interestCharge) - serviceCharge;

            transactions.Clear();
        }
    }
}
