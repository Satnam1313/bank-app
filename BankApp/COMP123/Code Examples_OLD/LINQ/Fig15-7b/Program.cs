using System;
using System.Linq;
namespace Fig15_7
{
    public class LinqDemo1
    {
        public static void Main()
        {
            int[] numbers = { 6, 4, 2, 1, 8, 3, 7, 5, 2, 0 };

            //var highNums =  from x in numbers
            //                select x;

           
            //var highNums = from x in numbers
            //               orderby x
            //               select x;

            
            //var highNums = from x in numbers
            //               orderby x descending
            //               select x;

           
             var highNums = from x in numbers
                            where x > 6
                            select x;
            
            // printing the array values

            Console.WriteLine("Numbers are : ");
            foreach (var n in highNums)
            {
                Console.Write("{0} ", n);
            }
            Console.WriteLine();
        }
    }
}