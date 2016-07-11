using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Version3
{
    class version3
    {
        static void Main(string[] args)
        {

            Console.WriteLine("VERSION 3.0\n");
            
            // variables
            int a, b, c;
            // input numbers
            Console.WriteLine("Enter first number:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter first number:");
            b = Convert.ToInt32(Console.ReadLine());
            Sum(a,b);

        }

        // method definition

        public static void Sum(int i, int j)
        {
            int k;
            // calculate sum
            k = i + j;
            //display result
            Console.WriteLine("Sum : " + k);
        }
    }
}
