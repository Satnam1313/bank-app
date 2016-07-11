using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Version4
{
    class version4
    {
        static void Main(string[] args)
        {
            Console.WriteLine("VERSION 4.0\n");
            int s;
            s = Sum();
            //display result
            Console.WriteLine("Sum : " + s);
        }

        // method definition

        public static int Sum()
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
            //return value
            return c;
        }
    }
}
