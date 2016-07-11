using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BankApp
{
   abstract class Account
    {
        public readonly List<Person> holders = new List<Person>();
        public readonly List<Transaction> transactions = new List<Transaction>();
        public readonly string Number;
        private static int LAST_NUMBER = 100000;

        public double Balance { get; protected set; }
        public double LowestBalance { get; protected set; }

        public Account(string type, double balance)
        {
            this.Balance = balance;
            this.LowestBalance = balance;        
            Number = type + "-" + LAST_NUMBER;

            LAST_NUMBER++;
           

        }
        public void AddUser(Person person)
        {
            holders.Add(person);
        }
        public void Deposit(double amount, Person person)
        {
            this.Balance += amount;
            this.LowestBalance = this.Balance;
            Transaction currentTrans = new Transaction(this.Number, amount, this.Balance, person, DateTime.Now);
            transactions.Add(currentTrans);
        }

        public bool IsHolder(string name)
        {
            bool nameFound = false;
            foreach (Person holderName in holders)
            {
                if (holderName.Name == name)
                {
                    nameFound = true;
                    break;
                }
            }
            return nameFound;
        }

        public abstract void PrepareMonthlyReport();

       public override string ToString()
       {
           string transS = "\n\n";
           foreach (Transaction a in transactions)
           {
               transS += a.ToString();
           }

           string holdersS = "";
           foreach (Person p in holders)
           {
               holdersS += string.Format("[{0}] ", p.Name);
           }

           string str = string.Format("***FULL ACCOUNT VIEW: ***\n\n");
           str += string.Format("Account Number: {0} \nAccount holders: {1} \nCurrent Balance: {2}, \nAll Transactions: {3}\n", Number, holdersS, Balance, transS);
           
           str += string.Format("\n");
           return str;
       }

    }
}
