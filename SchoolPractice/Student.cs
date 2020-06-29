using System;

// Start working here with your Student class.
// To instantiate the Student class, add your code to the Main method in Program

namespace SchoolPractice
{
    public class Student
    {
        private string Name { get; set; }
        private int StudentId { get; set; }
        private int NumberOfCredits { get; set; }
        private double Gpa { get; set; }

        public Student( string name, int studentId, int numCredits, double gpa)
        {
            this.Name = name;
            this.StudentId = studentId;
            this.NumberOfCredits = numCredits;
            this.Gpa = gpa;
        }

    }
}
