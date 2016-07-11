// This is code example for methods.
//Version 1.0
//Sujeet Lohan
//Lab Assignment 01

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Version1
{
    class version1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("VERSION 1.0\n");   
            
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

        }// end Main
    } // end class
}
