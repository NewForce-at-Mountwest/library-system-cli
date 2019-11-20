using Library_System_CLI.Models;
using System;
using System.Collections.Generic;

namespace Library_System_CLI
{
    class Program
    {
        static void Main(string[] args)
        {

            // List all the books
            BookRepository bookRepo = new BookRepository();

            List<Book> allBooks = bookRepo.GetAllBooks();
            Console.WriteLine("------ Books --------");
            allBooks.ForEach(book => Console.WriteLine(book.Title));

            // List all the patrons

            PatronRepository patronRepo = new PatronRepository();
            List<Patron> allPatrons = patronRepo.GetAllPatrons();
            Console.WriteLine();
            Console.WriteLine("------ Patrons --------");
            allPatrons.ForEach(patron => Console.WriteLine($"{patron.FirstName} {patron.LastName}"));





        }
    }
}
