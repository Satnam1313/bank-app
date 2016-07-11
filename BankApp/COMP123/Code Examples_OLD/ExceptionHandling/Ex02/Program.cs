using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex02
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] ar = new int[5];

            try
            {
                //Input array elements
                Console.WriteLine("\n\nInput array elements:");
                for (int i = 0; i < ar.Length; ++i)
                {
                    ar[i] = Convert.ToInt32(Console.ReadLine());
                }

                //printing an array

                Console.WriteLine("\n\narray elements:");
                for (int i = 0; i <= ar.Length; ++i)
                {
                    Console.WriteLine(ar[i]);
                }
            } //end try
            catch (FormatException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            } //end catch

            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                Console.WriteLine("Error: " + ex.Source);
                Console.WriteLine("Error: " + ex.GetType());
            } //end catch

            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                Console.WriteLine("Error: " + ex.Source);
                Console.WriteLine("Error: " + ex.GetType());

            } //end catch

            
            Console.WriteLine("\n\nFinished printing the array\n\n");

        } //end main


    }
}
