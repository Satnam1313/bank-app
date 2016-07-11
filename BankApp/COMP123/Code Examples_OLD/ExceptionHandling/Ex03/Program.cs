using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03
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
                result = Div(number1, number2); //method call
                result = Div2(); //another method call
                Console.WriteLine("The result is " + result);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            Console.WriteLine("End of program ");
        } //end main

        public static double Div(double num1, double num2)
        {
                return num1 / num2;
        }

        public static double Div2()
        {
            double num1;
            double num2;
            //Read the first number
            Console.WriteLine("Enter first number >> ");
            num1 = Convert.ToInt32(Console.ReadLine());
            //Read the second number
            Console.WriteLine("Enter second number >> ");
            num2 = Convert.ToInt32(Console.ReadLine());
            return num1 / num2;
        }
    }
}
