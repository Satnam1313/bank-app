using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByRef
{
    class ByRef2
    {
        static void Main(string[] args)
        {
            int num1;
            Console.WriteLine("Enter the number - num1:");
            //num1 = Convert.ToInt32(Console.ReadLine());
            num1 = 100;
            Display(ref num1); // -- method call
            Console.WriteLine("Num1: " + num1);
            num1 = 500;
            Display(ref num1); // -- method call
            Console.WriteLine("Num1: " + num1);

        } //end Main()

        // Method Sum definition

        public static void Display(ref int x)
        {
            Console.WriteLine("X1: " + x);
            x = 700;

        } //  end Swap()

 
    }
}
