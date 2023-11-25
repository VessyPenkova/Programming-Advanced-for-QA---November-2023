using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students
{
    public class Student
    {
        public Student(string firstName, string secondName, double grade)
        {
            this.FirstName = firstName;
            this.SecondName = secondName;
            this.Grade = grade;
        }

        string firstName;
        string secondName;
        double grade;
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public double Grade { get; set; }
    }
}
