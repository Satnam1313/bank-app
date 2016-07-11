using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example04
{
    class Program
    {
        static void Main(string[] args)
        {
            double sal;
            Employee employee1 = new Employee();
            sal = employee1.CalculatSalary(16, 35);
            Console.WriteLine(" Salary : " + sal);
            sal = employee1.CalculatSalary(20, 50);
            Console.WriteLine(" Salary : " + sal);
            sal = employee1.CalculatSalary(20, 50);
            Console.WriteLine(" Salary : " + sal);
           // employee2
            Employee employee2 = new Employee();
            
            sal = employee2.CalculatSalary(22, 45);
            Console.WriteLine(" Salary : " + sal);

        }
    } //end class Program

    class Employee
    {
        public double CalculatSalary(double rate, double hours)
        {
            return rate * hours;
        }


    }//end class Employee

}
