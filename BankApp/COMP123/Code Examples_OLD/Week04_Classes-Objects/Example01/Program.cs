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
           // varibales
            double midterm, final, quizzes, avg;
            // Input data
            Console.WriteLine(" Input the marks for Mid-term, Final, Quizzes :");
            midterm = Convert.ToDouble(Console.ReadLine());
            final = Convert.ToDouble(Console.ReadLine());
            quizzes = Convert.ToDouble(Console.ReadLine());
            // create class objects
            //GradeBook gradebook1 = new GradeBook();
            GradeBook gradebook1; 
            gradebook1 = new GradeBook();

            // Calling class GradeBook Method - Average
            avg = gradebook1.Average(midterm, final, quizzes);
           Console.WriteLine("Average Marks for gradebook1: {0:f2}", avg);

            GradeBook gradebook2 = new GradeBook();
            Console.WriteLine("Average Marks for gradebook2: {0:f2}", gradebook2.Average(12.5, 30.5, 6.5));

            GradeBook gradebook3 = new GradeBook();
            Console.WriteLine("Average Marks for gradebook2: {0:f2}", gradebook3.Average(22.5, 40.5, 7.5));


        } // end Main
    } // class Program
        
    // Class Definitiongradebook1.
     class GradeBook
        {
            // Method definition
            public double Average(double m, double f, double q)
            {
                double avg;
                avg = (m + f + q) / 3;
                return avg;
            } //  end Average
        } // end GradeBook
    
} // end namespace - Example 01

