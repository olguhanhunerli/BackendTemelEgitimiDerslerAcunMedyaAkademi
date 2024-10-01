
using System;

namespace EducationalInstitutionApplication
{
    public class Student : Person
    {
        public int GradeLevel { get; set; }

        public override void AttendClass()
        {
            Console.WriteLine($"{Name} is attending grade {GradeLevel} class");
        }
    }
}
