using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example04
{
    class Example04
    {
        static void Main(string[] args)
        {
            double sal;
            
            //Employee employee1 = new Employee();
            //Employee employee2 = new Employee();
            //Employee employee3 = new Employee();
            //Employee employee4 = new Employee();

            Employee[] employee = new Employee[4];


            //version 2.0
            for (int i = 0; i < employee.Length; ++i)
            {
                employee[i] = new Employee();
                employee[i].CalculateSalary(12, 25);
            }

        }//end Main Method
    }//end class example04

    class Employee
    {
        public double CalculateSalary(double rate, double hours)
        {
            double salary;
            salary = rate * hours;
            return salary;
        }
    }

}
