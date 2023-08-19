using System;
using System.Collections.Generic;
using System.Text;

namespace Persons
{
    class Student : Person
    {
        private double GPA { get; set; }

        public Student(string firstName, string lastName, string address, int id, double gpa)
            : base(firstName, lastName, address, id)
        {
            GPA = gpa;
        }

        public double GetGPA()
        {
            return GPA;
        }

        public void SetGPA(double gpa)
        {
            GPA = gpa;
        }

        public override void Display()
        {
            base.Display();
            Console.WriteLine($"GPA: {GPA}");
        }
    }
}