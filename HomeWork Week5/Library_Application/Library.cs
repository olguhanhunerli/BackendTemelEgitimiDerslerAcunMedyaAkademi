
using System;
using System.Collections.Generic;

namespace LibraryApplication
{
    public class Library
    {
        private List<Book> books = new List<Book>();

        public void AddBook(Book book)
        {
            books.Add(book);
        }

        public void ListBooks()
        {
            Console.WriteLine("Books in library:");
            foreach (var book in books)
            {
                Console.WriteLine($"{book.Title} by {book.Author} (ISBN: {book.ISBN})");
            }
        }
    }
}
