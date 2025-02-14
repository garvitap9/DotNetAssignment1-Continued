using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PocEnumBmi
{
    public class Person
    {
        public int PersonId { get; set; }
        public string PersonName { get; set; }
        public int PersonAge { get; set; }
        public double PersonHeight { get; set; } //Height datatype double
        public double PersonWeight { get; set; } //Weight in Kgs so datatype double

        public Person(int personId, string personName, int personAge, double personHeight, double personWeight) : this(personId, personName, personAge)
        {
            this.PersonHeight = personHeight;
            this.PersonWeight = personWeight;
        }
        public Person(int personId, string personName, int personAge)
        {
            this.PersonId = personId;
            this.PersonName = personName;
            this.PersonAge = personAge;
            this.PersonHeight = 5;
            this.PersonWeight = 50;
        }

        public double CalculateBMIScore()
        {
            double bmiScore = PersonWeight / (PersonHeight * PersonHeight);
            return bmiScore;
        }

        public string BodyTypeDeteminer(double bmIScore)
        {

            if (bmIScore < 18.5)
            {
                return Convert.ToString(BodyType.Underweight);
            }
            else if (18.5 < bmIScore && bmIScore < 24.9)
            {
                return Convert.ToString(BodyType.NormalWeight); 
            }
            else if (25.0 < bmIScore && bmIScore < 29.9)
            {
                return Convert.ToString(BodyType.OverWeight);
            }
            else
            {
                return Convert.ToString(BodyType.Obesity);
            }

        }
    }
}
