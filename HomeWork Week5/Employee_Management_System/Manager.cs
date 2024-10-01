
using System;

namespace EmployeeManagementSystem
{
    public class Manager : Employee
    {
        public int NumberOfTeams { get; set; }

        public override void ShowDetails()
        {
            Console.WriteLine($"Manager: {Name}, ID: {Id}, Salary: {Salary}, Teams: {NumberOfTeams}");
        }
    }
}
