using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Sheharyar_Khan_Ex_01
{
    class Program
    {
        static void Main(string[] args)
        {
            // try statement
            try
            {
                // Declare array for students
                Student[] students = 
                {          
                new Student( "James", "Blue", 50 ),
                new Student( "Ashley", "Blue", 80 ),
                new Student( "Matthew", "Brown", 90 ),
                new Student( "James", "Brown", 40 ),
                new Student( "Luke", "Brown", 70 ) };

                Console.WriteLine("Original array");
                foreach (var element in students)
                    Console.WriteLine(element);

                // Use LINQ to order names alphabetically
                var nameSorted =
                from s in students
                orderby s.LastName, s.FirstName
                select s;

                // Display information for students alphabetically ordered
                Console.WriteLine("\nStudent names ordered alphabetically by first name and last name");

                foreach (var s in nameSorted)
                {
                    Console.WriteLine("{0,-10} {1,-10} {2,10:P}", s.FirstName, s.LastName, s.Grades / 100);
                }


                // Filter for a range of grades over 60%
                double highGrade = 60;
                var goodStudents =
                from g in students
                where g.Grades > highGrade
                select g;

                // Display information for students who scored over 60%
                Console.WriteLine("\nStudents who have scored more than {0}%", highGrade);
                foreach (var g in goodStudents)
                {
                    Console.WriteLine("{0,-10} {1,-10} {2,10:P}", g.FirstName, g.LastName, g.Grades / 100);
                }

                // Use LINQ to order grades
                var lowestGrade =
                from l in students
                orderby l.Grades
                select l;

                // Display information for student with highest grade
                Console.WriteLine("\nStudent with the lowest grade");
                if (lowestGrade.Any())
                    Console.WriteLine(lowestGrade.First());

                // Use LINQ to order grades
                var highestGrade =
                from h in students
                orderby h.Grades descending
                select h;

                // Display information for student with lowest grade
                Console.WriteLine("\nStudent with the highest grade");
                if (highestGrade.Any())
                    Console.WriteLine(highestGrade.First());


                // Use LINQ to select student last names
                var firstNames =
                from e in students
                select e.FirstName;

                // Display unique first names with Distinct method
                Console.WriteLine("\nUnique student first names:");
                foreach (var element in firstNames.Distinct())
                    Console.WriteLine(element);

            }// End try

            catch (Exception ex)
            {
                Console.WriteLine("\nERROR OCCURED!" + ex.Message);
            }// End catch

        }
    }
}