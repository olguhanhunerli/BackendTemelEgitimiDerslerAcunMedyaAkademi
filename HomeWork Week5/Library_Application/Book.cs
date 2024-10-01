
using System;

namespace LibraryApplication
{
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int Pages { get; set; }
        public string ISBN { get; set; }
        public bool IsBorrowed { get; private set; }

        public void Borrow()
        {
            if (!IsBorrowed)
            {
                IsBorrowed = true;
                Console.WriteLine($"{Title} has been borrowed.");
            }
            else
            {
                Console.WriteLine($"{Title} is already borrowed.");
            }
        }

        public void Return()
        {
            if (IsBorrowed)
            {
                IsBorrowed = false;
                Console.WriteLine($"{Title} has been returned.");
            }
            else
            {
                Console.WriteLine($"{Title} was not borrowed.");
            }
        }
    }
}
