using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PocEnumBmi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("BMI CALCULATION OF A PERSON USING ENUM With Proof of concept!");
            Console.WriteLine(" ");
            Person person1 = new Person(1, "Garima", 16, 1.74, 65.00);
            Person person2 = new Person(2, "Aakash", 27);
            Person person3 = new Person(3, "Gagan", 30, 1.70, 100.00);
            Person person4 = new Person(4, "Deepa", 21, 1.79, 95.00);
            Program.DisplayPersonDetails(person1);
            Program.DisplayPersonDetails(person2);
            Program.DisplayPersonDetails(person3);
            Program.DisplayPersonDetails(person4);
        }
        public static void DisplayPersonDetails(Person person)
        {
            Console.WriteLine(" ");
            double getBmiScore = person.CalculateBMIScore();
            string getBodyType = person.BodyTypeDeteminer(getBmiScore);
            Console.WriteLine($"Person Id: {person.PersonId} | Person Name: {person.PersonName} | Person Age: {person.PersonAge} | Person Height: {person.PersonHeight} | Person Weight: {person.PersonWeight}");
            Console.WriteLine($"Person BMI SCore: {getBmiScore} | Person Body Type: {getBodyType}");
        }
    }
}
