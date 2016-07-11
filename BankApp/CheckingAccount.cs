using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp
{
    class CheckingAccount: Account
    {
        public double COST_PER_TRANSACTION = 0.05;
        public double INTEREST_RATE  = 0.005;
        private bool hasOverdraft;

        public CheckingAccount(double balance = 0, bool hasOverdraft = false)
            : base("CK", balance)
        {
            this.Balance = balance;
            this.hasOverdraft = hasOverdraft;

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
                if ((amount <= this.Balance) || (hasOverdraft))
                {
                    base.Deposit(-amount, person);
                }
            }
        }
        public override void PrepareMonthlyReport()
        {
            double serviceCharge = COST_PER_TRANSACTION * base.transactions.Count();
            double interestCharge = (Balance * INTEREST_RATE) / 12;

            Balance = (Balance + interestCharge) - serviceCharge;
            
            transactions.Clear();

        }


    }
}
