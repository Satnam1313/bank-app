using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example01
{
    class Program
    {
        static void Main(string[] args)
        {
            double number1;
            double number2;
            double result;

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

            catch (FormatException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

           Console.WriteLine("End of program ");
            
        }
    }
}
