using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Version5
{
    class version5
    {
        static void Main(string[] args)
        {
            Console.WriteLine("VERSION 5.0\n");
            // variables
            int a, b, c;
            // input numbers
            Console.WriteLine("Enter first number:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter first number:");
            b = Convert.ToInt32(Console.ReadLine());
            c = Sum(a, b); //method call
            //display result
            Console.WriteLine("Sum : " + c);
        }
      // method definition
     public static int Sum(int a, int b)
        {
            int c;
            // calculate sum
            c = a + b;
            //return value
            return c;
        }
    }
}
