
using System;

namespace LibraryApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();
            library.AddBook(new Book { Title = "1984", Author = "George Orwell", Pages = 328, ISBN = "123456789" });
            library.AddBook(new Book { Title = "Brave New World", Author = "Aldous Huxley", Pages = 288, ISBN = "987654321" });

            library.ListBooks();
        }
    }
}
