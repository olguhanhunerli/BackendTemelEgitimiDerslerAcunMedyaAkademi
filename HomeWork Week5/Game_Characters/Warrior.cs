
using System;

namespace GameCharacters
{
    public class Warrior : Character
    {
        public override void Attack()
        {
            Console.WriteLine($"{Name} attacks with a sword!");
        }

        public void SwordAttack()
        {
            Console.WriteLine($"{Name} performs a powerful sword attack!");
        }
    }
}
