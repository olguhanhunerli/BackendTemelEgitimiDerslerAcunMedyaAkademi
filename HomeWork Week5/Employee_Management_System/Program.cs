
using System;

namespace EmployeeManagementSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Manager manager = new Manager { Name = "Alice", Id = 1, Salary = 90000, NumberOfTeams = 3 };
            Developer developer = new Developer { Name = "Bob", Id = 2, Salary = 80000, ProgrammingLanguage = "C#" };
            Intern intern = new Intern { Name = "Charlie", Id = 3, Salary = 30000, Mentor = "Alice" };

            manager.ShowDetails();
            developer.ShowDetails();
            intern.ShowDetails();
        }
    }
}
