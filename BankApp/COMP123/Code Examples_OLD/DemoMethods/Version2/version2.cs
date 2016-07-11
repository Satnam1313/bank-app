using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Version2
{
    class version2
    {
        static void Main(string[] args)
        {
            // method call
            Console.WriteLine("VERSION 2.0\n");            
            Sum();
            Sum();
            Sum();
        }

        // method definition

        public static void Sum()
        {
            // variables
            int a, b, c;
            // input numbers
            Console.WriteLine("Enter first number:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter first number:");
            b = Convert.ToInt32(Console.ReadLine());

            // calculate sum
            c = a + b;
            //display result
            Console.WriteLine("Sum : " + c);
        }
    }
}
