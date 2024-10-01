
using System;

namespace EducationalInstitutionApplication
{
    public abstract class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public abstract void AttendClass();
    }
}
