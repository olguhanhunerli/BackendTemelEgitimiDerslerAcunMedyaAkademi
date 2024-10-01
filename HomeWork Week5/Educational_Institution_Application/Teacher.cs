
using System;

namespace EducationalInstitutionApplication
{
    public class Teacher : Person
    {
        public string SubjectTaught { get; set; }

        public override void AttendClass()
        {
            Console.WriteLine($"{Name} is teaching {SubjectTaught}");
        }
    }
}
