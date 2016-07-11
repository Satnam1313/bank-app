using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example05
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            Console.WriteLine("Total payment amount : " + product1.PaymentAmount(2.5,120));
            Employee employee1 = new Employee();
            double sal= employee1.CalculatSalary(2.5, 120);
            Console.WriteLine("Total payment amount : " + sal);

        }
    } //end class Program

    class Product
    {
        public double PaymentAmount(double pricePerItem, int quantity)
        {
            double totalAmount;
            totalAmount = pricePerItem * quantity;
            return totalAmount;
        } //end method

    } //end class Product

    class Employee
    {
        public double CalculatSalary(double rate, double hours)
        {
            return rate * hours;
        }


    }//end class Employee
} //end namespace
