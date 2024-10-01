
using System;

namespace EmployeeManagementSystem
{
    public class Intern : Employee
    {
        public string Mentor { get; set; }

        public override void ShowDetails()
        {
            Console.WriteLine($"Intern: {Name}, ID: {Id}, Salary: {Salary}, Mentor: {Mentor}");
        }
    }
}
