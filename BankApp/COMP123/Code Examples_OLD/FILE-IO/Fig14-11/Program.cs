﻿using System;
using System.IO;
namespace Fig14_11
{
    public class WriteSequentialFile
    {
        public static void Main()
        {
            const int END = 999;
            const string DELIM = ",";
            const string FILENAME = @"C:\MyDir\EmployeeData.txt";
      Employee emp = new Employee();
      FileStream outFile = new FileStream(FILENAME,FileMode.Create, FileAccess.Write);
            StreamWriter writer = new StreamWriter(outFile);
            Console.Write("Enter employee number or " + END + " to quit >> ");
            emp.EmpNum = Convert.ToInt32(Console.ReadLine());
            while (emp.EmpNum != END)
            {
                Console.Write("Enter last name >> ");
                emp.Name = Console.ReadLine();
                Console.Write("Enter salary >> ");
                emp.Salary = Convert.ToDouble(Console.ReadLine());
                writer.WriteLine(emp.EmpNum + DELIM + emp.Name + DELIM + emp.Salary);
                Console.Write("Enter next employee number or " + END + " to quit >> ");
                emp.EmpNum = Convert.ToInt32(Console.ReadLine());
            }
            writer.Close();
            outFile.Close();
        }
    }
}