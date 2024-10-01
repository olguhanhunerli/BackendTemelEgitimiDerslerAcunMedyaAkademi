
using System;

namespace EmployeeManagementSystem
{
    public class Employee
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public decimal Salary { get; set; }

        public virtual void ShowDetails()
        {
            Console.WriteLine($"Employee: {Name}, ID: {Id}, Salary: {Salary}");
        }
    }
}
