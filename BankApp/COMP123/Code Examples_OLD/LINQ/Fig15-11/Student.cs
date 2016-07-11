using System;
using System.Collections.Generic;
using System.Linq;

namespace Fig15_11
{
    class Student
    {
        public Student(int num, string name, double avg)
        {
            IdNumber = num;
            Name = name;
            GradePointAverage = avg;
        }
        public int IdNumber { get; set; }
        public string Name { get; set; }
        public double GradePointAverage { get; set; }
    }
}