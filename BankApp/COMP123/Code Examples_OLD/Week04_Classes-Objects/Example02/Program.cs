using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example02
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student01 = new Student();
            
            student01.Print(111, "sujeet", "lohan");
            student01.Print(112, "sujeet2", "lohan2");
            student01.Print(113, "sujeet3", "lohan3");

            Student student02 = new Student();
            student02.Print(222, "sujeet2", "lohan2");
            

        }
    } // end class Program

    // class Student
    class Student
    {

        public void Print(int id, string fn, string ln)
        {
            Console.WriteLine(" Id : {0} \n First Name: {1} \n Last Name: {2}", id, fn, ln);
        } // end Print()

    } //end Student

}// end namespace Example02
