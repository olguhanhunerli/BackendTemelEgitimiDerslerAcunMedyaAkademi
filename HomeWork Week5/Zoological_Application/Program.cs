
using System;

namespace ZoologicalApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Lion lion = new Lion { Name = "Leo", Age = 5, Species = "Lion" };
            Elephant elephant = new Elephant { Name = "Dumbo", Age = 10, Species = "Elephant" };
            Giraffe giraffe = new Giraffe { Name = "Longneck", Age = 7, Species = "Giraffe" };

            lion.MakeSound();
            elephant.MakeSound();
            giraffe.MakeSound();
        }
    }
}
