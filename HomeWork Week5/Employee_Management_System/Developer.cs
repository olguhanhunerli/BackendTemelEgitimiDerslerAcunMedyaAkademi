
using System;

namespace EmployeeManagementSystem
{
    public class Developer : Employee
    {
        public string ProgrammingLanguage { get; set; }

        public override void ShowDetails()
        {
            Console.WriteLine($"Developer: {Name}, ID: {Id}, Salary: {Salary}, Language: {ProgrammingLanguage}");
        }
    }
}
