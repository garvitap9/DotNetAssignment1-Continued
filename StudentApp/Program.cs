using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student(1,"Amar", 9.7);
            Student student2 = new Student(2,"Reema", 8.5);
            Student student3 = new Student(3,"Mohini", 10.0);
            Console.WriteLine("Student Details:");
            Program.DisplayStudentDetails(student1);
            Program.DisplayStudentDetails(student2);
            Program.DisplayStudentDetails(student3);
        }
        public static void DisplayStudentDetails(Student student)
        {
            Console.WriteLine(" ");
            
            Console.WriteLine($"Roll Number: {student.RollNumber}");
            Console.WriteLine($"Student Name: {student.StudentName}" );
            Console.WriteLine($"Student CGPA Scored: {student.StudentGpa}");
            Console.WriteLine($"Student Percentage scored: {student.ConvertCGPAToPercentage()}%");

        }
    }
}
