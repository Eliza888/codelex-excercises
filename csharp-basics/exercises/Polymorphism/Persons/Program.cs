using System.Buffers.Text;
using System.ComponentModel;
using System.Net.NetworkInformation;
using System.Numerics;
using System;

namespace Persons
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student("John", "Doe", "123 Main St", 1, 3.8);
            Employee employee = new Employee("Jane", "Smith", "456 Elm St", 2, "Software Engineer");

            Console.WriteLine("Student:");
            student.Display();
            Console.WriteLine();

            Console.WriteLine("Employee:");
            employee.Display();
        }
    }
}