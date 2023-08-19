using System;
using System.Collections.Generic;
using System.Text;

namespace Persons
{
    class Employee : Person
    {
        private string JobTitle { get; set; }

        public Employee(string firstName, string lastName, string address, int id, string jobTitle)
            : base(firstName, lastName, address, id)
        {
            JobTitle = jobTitle;
        }

        public string GetJobTitle()
        {
            return JobTitle;
        }

        public void SetJobTitle(string jobTitle)
        {
            JobTitle = jobTitle;
        }

        public override void Display()
        {
            base.Display();
            Console.WriteLine($"Job Title: {JobTitle}");
        }
    }
}