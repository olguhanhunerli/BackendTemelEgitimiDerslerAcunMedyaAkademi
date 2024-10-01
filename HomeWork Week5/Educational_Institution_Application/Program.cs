
using System;

namespace EducationalInstitutionApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Teacher teacher = new Teacher { Name = "Mr. Smith", Age = 45, SubjectTaught = "Mathematics" };
            Student student = new Student { Name = "Jane Doe", Age = 16, GradeLevel = 10 };

            teacher.AttendClass();
            student.AttendClass();
        }
    }
}
