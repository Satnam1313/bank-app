using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByOut
{
    class ByOut
    {
        static void Main(string[] args)
        {
            int num1;
            Display(out num1);
            Console.WriteLine("After FIRST METHOD CALL:");
            Console.WriteLine("Num1: " + num1);
            num1 = 200;
            Console.WriteLine("Num1: " + num1);
            Display(out num1);
            Console.WriteLine("Num1: " + num1);// --

        } //end Main()

        // Method Sum definition

        public static void Display(out int x)
        {
            x = 400;

        } //  end Swap()


    }
}
