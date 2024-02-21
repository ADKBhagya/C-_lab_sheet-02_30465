using System;
namespace BookApp
{
    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book();

            book.Title = "Harry Potter";
            book.Author = "J.K.Rowling";

            Console.WriteLine("Book Title: " + book.Title);
            Console.WriteLine("Author: " + book.Author);
            Console.ReadLine(); 
        }
    }
}
