using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example03
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount bankaccount01 = new BankAccount();
            Console.WriteLine(" Value of new balance after Withdrawal : " + bankaccount01.Debit(1000, 250));
            Console.WriteLine(" Value of new balance after deposit : " + bankaccount01.Credit(1000, 500));
        }
    } //end class Program

    public class BankAccount
    {
        public double Debit(double bal, double withdrawAmt)
        {
            double newbal;
            newbal = bal - withdrawAmt;
            return newbal;

        } //end Method - Debit

        public double Credit(double bal, double depositAmt)
        {
            double newbal;
            newbal = bal + depositAmt;
            return newbal;

        } //end Method - Credit

    } // end class - BankAccount


}
