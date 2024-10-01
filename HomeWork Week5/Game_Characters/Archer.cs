
using System;

namespace GameCharacters
{
    public class Archer : Character
    {
        public override void Attack()
        {
            Console.WriteLine($"{Name} shoots an arrow!");
        }

        public void ArrowShot()
        {
            Console.WriteLine($"{Name} performs a deadly arrow shot!");
        }
    }
}
