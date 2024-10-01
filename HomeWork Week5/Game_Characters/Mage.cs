
using System;

namespace GameCharacters
{
    public class Mage : Character
    {
        public override void Attack()
        {
            Console.WriteLine($"{Name} casts a spell!");
        }

        public void CastSpell()
        {
            Console.WriteLine($"{Name} casts a powerful spell!");
        }
    }
}
