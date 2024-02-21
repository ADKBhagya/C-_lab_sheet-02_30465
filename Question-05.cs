using System;
using System.Collections.Generic;


namespace LibrarySystem
{
    class LibraryBook
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public bool Available { get; set; }

        public LibraryBook(string title, string author, bool available)
        {
            Title = title;
            Author = author;
            Available = available;
        }

        public void BorrowBook()
        {
            if (Available)
            {
                Available = false;
                Console.WriteLine($"Book '{Title}' by {Author} has been borrowed.");
            }
            else
            {
                Console.WriteLine($"Sorry, book '{Title}' by {Author} is not available.");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<LibraryBook> library = new List<LibraryBook>()
            {
                new LibraryBook("Harry Potter", "J.K.Rowling", true),
                new LibraryBook("The kite runner", "Khaled Hossieni ", true),
                new LibraryBook("The power of positive thinking", "Dr Norman Vincent Peale", false),
                new LibraryBook("Pride and Prejudice", "Jane Austen", true)
            };

            Console.WriteLine("Initial Library Status:");
            DisplayLibraryStatus(library);

            library[2].BorrowBook(); 
            
            Console.WriteLine("\nUpdated Library Status:");
            DisplayLibraryStatus(library);

            Console.ReadLine(); 
        }

        static void DisplayLibraryStatus(List<LibraryBook> library)
        {
            foreach (var book in library)
            {
                Console.WriteLine($"Title: {book.Title}, Author: {book.Author}, Available: {(book.Available ? "Yes" : "No")}");
            }
        }
    }
}
