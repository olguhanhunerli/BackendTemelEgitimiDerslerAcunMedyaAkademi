
using System;

namespace GameCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            Warrior warrior = new Warrior { Name = "Aragon", Health = 100 };
            Mage mage = new Mage { Name = "Gandalf", Health = 80 };

            warrior.SwordAttack();
            mage.CastSpell();
        }
    }
}
