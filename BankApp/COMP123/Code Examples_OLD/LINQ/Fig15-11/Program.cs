using System;
using System.Linq;

namespace Fig15_11
{

    public class LinqDemo2
    {
        public static void Main()
        {
            Student[] stus = { new Student(1, "Jones", 3.1),
                new Student(2, "Kimball", 2.9),
                new Student(5, "Oliver", 2.6),
                new Student(6, "Mitchell", 3.0),
                new Student(8, "Lee", 4.0),
                new Student(10, "Cooper", 3.5) };

            const double CUTOFF = 3.0;
            
            //LINQ
            var goodStudents = from s in stus
                             where s.GradePointAverage > CUTOFF
                            select s;
            
            Console.WriteLine("Students with GPA > " + CUTOFF);
            foreach (var s in goodStudents)
            {
                Console.WriteLine("{0,3} {1,-8} {2,5}", s.IdNumber, s.Name, s.GradePointAverage.ToString("F1"));
            }
        }
    }
}
