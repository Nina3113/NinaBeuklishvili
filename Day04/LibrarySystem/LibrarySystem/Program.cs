using LibrarySystem;

Library myLibrary = new Library(10);

Book book1 = new Book("The Metamorphosis", "Franz Kafka", 1915);
Book book2 = new Book("Mysteries", "Knut Hamsun", 1892);
Book book3 = new Book("1984", "George Orwell", 1949);
Book book4 = new Book("The Rebel", "Albert Camus", 1951);
Book book5 = new Book("Dark Matter", "Blake Crouch", 2016);
Book book6 = new Book("The Metamorphosis", "Franz Kafka2", 1915);

myLibrary.AddBook(book1);
myLibrary.AddBook(book2);
myLibrary.AddBook(book3);
myLibrary.AddBook(book4);
myLibrary.AddBook(book5);
myLibrary.AddBook(book6);

myLibrary.PrintBooks();

//Get the number of books
int numberOfBooks = myLibrary.Count;
Console.WriteLine($"\nNumber of books in the library: {numberOfBooks} \n");

//Find books by title
string searchTitle = "The Metamorphosis";
List<Book> matchingBooks = myLibrary.FindBooksByTitle(searchTitle);

//Print the matching books

if (matchingBooks.Count > 0)
{
    Console.WriteLine($"Matching books with the title \"{searchTitle}\":");
    foreach (Book book in matchingBooks)
    {
        Console.WriteLine($"{book.Title} by {book.Author} ({book.Year})");
    }
}
else
{
    Console.WriteLine($"No books with the title '{searchTitle}' found.");
}

//Remove the book
myLibrary.RemoveBook(book6);

//After removal
myLibrary.PrintBooks();