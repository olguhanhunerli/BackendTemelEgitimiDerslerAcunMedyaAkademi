
using System;

namespace GameCharacters
{
    public abstract class Character
    {
        public string Name { get; set; }
        public int Health { get; set; }

        public abstract void Attack();
    }
}
