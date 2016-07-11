using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace Sheharyar_Khan_Ex_01
{
    class Student
    {
        // Declare instance data members
        private string firstName;
        private string lastName;
        private double grades;

        //Declare properties
        public string FirstName { get; set; } // End property
        public string LastName { get; set; } // End property
        public double Grades
        {
            get
            {
                return grades;
            }
            set
            {
                if (value >= 40 && value <=100)
                {
                    grades = value;
                }
                else
                {
                    Console.WriteLine("A grade is out of range");
                    Environment.Exit(0);
                }
            }
        }// End property

        // Constructor
        public Student(string fName, string lName, double gr)
        {
            FirstName = fName;
            LastName = lName;
            Grades = gr;

        }// End constructor

        // ToString method to display student information
        public override string ToString()
        {
            return string.Format("{0,-10} {1,-10} {2,10:P}", FirstName, LastName, Grades/100);
        } // end method ToString
    }
}
