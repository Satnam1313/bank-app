using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByRef
{
    class ByRef
    {
        static void Main(string[] args)
        {
            int num1, num2, result;
            Console.WriteLine("Enter the first number - num1:");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number - num2:");
            num2 = Convert.ToInt32(Console.ReadLine());
            // before calling swap method
            Console.WriteLine("Before calling swap method !!!!");
            Console.WriteLine("Num1: " + num1);
            Console.WriteLine("Num2: " + num2);
             Swap(ref num1, ref num2);
            // after calling swap method
            Console.WriteLine("After calling swap method !!!!");
            Console.WriteLine("Num1: " + num1);
            Console.WriteLine("Num2: " + num2);

            
        } //end Main()

        // Method Sum definition

        public static void Swap(ref int x, ref int y)
        {
            int temp;
            temp = x;
            x = y;
            y = temp;

        } //  end Swap()
        
        //public static void Swap(int x, int y)
        //{
        //    int temp;
        //    temp = x;
        //    x = y;
        //    y = temp;
        //    //Console.WriteLine("X: " + x);
        //    //Console.WriteLine("Y: " + y);
        //    //x = 100;
        //    //y = 200;
        //    //Console.WriteLine("X: " + x);
        //    //Console.WriteLine("Y: " + y);

        //} //  end Swap()
    }
}
