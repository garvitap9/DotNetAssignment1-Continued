using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace StudentApp
{
    public class Student
    {
        public int RollNumber {  get; set; }
        public string StudentName {  get; set; }
        public double StudentGpa {  get; set; }

        public Student(int rollNumber, string studentName, double studentGpa)
        {
            //we will check for the conditions on roll number, student name and gpa
            if (rollNumber <= 0)
            {
                Console.WriteLine("The roll number must be positive!");
            }
               
            if (studentName.Length < 5)
            {
                studentName = "";
            }
                

            if (studentGpa < 1 || studentGpa > 10)
            { 
                Console.WriteLine("The CGPA must be between 1 and 10!!");
            }
                
            this.RollNumber = rollNumber;
            StudentName = studentName;
            StudentGpa = studentGpa;
        }

        public double ConvertCGPAToPercentage()
        {
            return StudentGpa * 9.5;
        }
    }
}
