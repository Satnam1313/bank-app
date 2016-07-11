using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_06
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1;
            int number2;
            int result;

            try
            {
                //Read the first number
                Console.WriteLine("Enter first number >> ");
                number1 = Convert.ToInt32(Console.ReadLine());

                //Read the second number
                Console.WriteLine("Enter second number >> ");
                number2 = Convert.ToInt32(Console.ReadLine());

                result = number1 / number2;

                Console.WriteLine("The result is " + result);
            }
            finally
            {
                Console.WriteLine("\nEnd of program - in the finally block\n\n ");
            }

        }
    }
}
