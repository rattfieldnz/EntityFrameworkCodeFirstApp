using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace attfire1_assignment2
{
    public class StudentRecordsItem
    {
        private int studentId;
        public int StudentId
        {
            get { return studentId; }
            set { studentId = value; }
        }

        private string firstName;
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
        
        private string lastName;
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        private int age;
        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        private string suburb;
        public string Suburb
        {
            get { return suburb; }
            set { suburb = value; }
        }

        private string townOrCity;
        public string TownOrCity
        {
            get { return townOrCity; }
            set { townOrCity = value; }
        }

        private string lessonName;
        public string LessonName
        {
            get { return lessonName; }
            set { lessonName = value; }
        }

        private string instrumentName;
        public string InstrumentName
        {
            get { return instrumentName; }
            set { instrumentName = value; }
        }

        private decimal lessonFeesOwed;
        public decimal LessonFeesOwed
        {
            get { return lessonFeesOwed; }
            set { lessonFeesOwed = value; }
        }

        private decimal instrumentFeesOwed;
        public decimal InstrumentFeesOwed
        {
            get { return instrumentFeesOwed; }
            set { instrumentFeesOwed = value; }
        }

        private decimal totalFeesOwed;
        public decimal TotalFeesOwed
        {
            get { return totalFeesOwed; }
            set { totalFeesOwed = value; }
        }

        public StudentRecordsItem(int studentId, string firstName, string lastName, int age, string suburb, 
            string townOrCity, string lessonName, string instrumentName, decimal lessonFeesOwed, 
            decimal instrumentFeesOwed, decimal totalFeesOwed)
        {
            this.StudentId = studentId;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.Suburb = suburb;
            this.TownOrCity = townOrCity;
            this.LessonName = lessonName;
            this.InstrumentName = instrumentName;
            this.LessonFeesOwed = lessonFeesOwed;
            this.InstrumentFeesOwed = instrumentFeesOwed;
            this.TotalFeesOwed = totalFeesOwed;
        }

        public override string ToString()
        {
            return StudentId + "  " 
                + FirstName + "  " 
                + LastName + "  " 
                + Age + "  " 
                + Suburb + "  " 
                + TownOrCity + "  " 
                + LessonName + "  "
                + InstrumentName + "  "
                + LessonFeesOwed + "  " 
                + InstrumentFeesOwed + "  "
                + TotalFeesOwed;
        }
    }
}
