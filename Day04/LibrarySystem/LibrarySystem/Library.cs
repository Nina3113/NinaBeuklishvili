using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem
{
    internal class Library
    {
        private Book[] books;

        public Library(int capacity) 
        {
            books = new Book[capacity];
        }

        public void PrintBooks()
        {
            Console.WriteLine("\nBooks in the library: ");
            foreach (Book book in books)
            {
                if (book != null)
                {
                    Console.WriteLine($"{book.Title} : {book.Author}");
                }
            }
        }

        public int Count
        {
            get
            {
                int count = 0;
                foreach (Book book in books)
                {
                    if (book != null)
                    {
                        count++;
                    }
                }
                return count;
            }
        }

        public void AddBook(Book book)
        {
            for (int i = 0; i < books.Length; i++)
            {
                if (books[i] == null)
                {
                    books[i] = book;
                    break;
                }
            }
        }

        public void RemoveBook(Book book)
        {
            for (int i = 0; i < books.Length; i++)
            {
                if (books[i] != null && books[i].Equals(book))
                {
                    books[i] = null;
                    break;
                }
            }
        }

        public List<Book> FindBooksByTitle(string title)
        {
            List<Book> matchingBooks = new List<Book>();
            foreach (Book book in books)
            {
                if (book != null && book.Title.Equals(title, StringComparison.OrdinalIgnoreCase))
                {
                    matchingBooks.Add(book);
                }

            }
            return matchingBooks;
        }
    }
}
