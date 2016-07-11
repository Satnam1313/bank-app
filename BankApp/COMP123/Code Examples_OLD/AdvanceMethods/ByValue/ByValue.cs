using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByValue
{
    class ByValue
    {
        static void Main(string[] args)
        {
            int num1, num2, result;
            Console.WriteLine("Enter the first number:");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number:");
            num2 = Convert.ToInt32(Console.ReadLine());
            result = Sum(num1, num2);
            Console.WriteLine("Sum: " + result);
            result = Sum(num1, num2, num3);
            result = Sum(num1, num2, num3, num4);
        } //end Main()

        // Method Sum definition
        public static int Sum(int x, int y)
        {
            int z;
            z = x + y;
            return z;
        } //  end Sum()
        // Method Sum definition
        public static int Sum(int i, int j, int k)
        {
            int z;
            z = i + j + k;
            return z;
        } //  end Sum()

        public static int Sum(int i, int j, int k, int l)
        {
            int z;
            z = i + j + k + l;
            return z;
        } //  end Sum()

        public static int Sum(int i, int j, int k, int l,int m)
        {
            int z;
            z = i + j + k + l + m;
            return z;
        } //  end Sum()
    }
}
