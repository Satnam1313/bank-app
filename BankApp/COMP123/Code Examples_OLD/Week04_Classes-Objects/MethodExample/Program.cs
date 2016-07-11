using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Average : " + Average(12.5, 10.75, 20.60));

        } //end method

        
        public static double Average(double m, double f, double q)
        {
            double avg;
            avg = (m + f + q) / 3;
            return avg;
        } //  end Average
    } //end class - program
}
