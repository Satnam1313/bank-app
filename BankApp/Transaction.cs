using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp
{
    class Transaction
    {
        public readonly string AccountNumber;
        public readonly double Amount;
        public readonly double EndBalance;
        public readonly Person Originator;
        public readonly DateTime Time;

        public Transaction(string accountNumber, double amount, double endBalance, Person person, DateTime time)
        {
            AccountNumber = accountNumber;
            Amount = amount;
            EndBalance = endBalance;
            Originator = person;
            Time = time;
        }
        public override string ToString()
        {
            return string.Format("Account Number: {0} \nName: {1} \nAmount: {2} \nTransaction Date: {3}", AccountNumber, Originator.Name, Amount, Time);
        }
    }
}
