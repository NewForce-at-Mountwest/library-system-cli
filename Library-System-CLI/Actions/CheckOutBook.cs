using Library_System_CLI.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Library_System_CLI.Actions
{
    class CheckOutBook
    {
        public static void CollectInput()
        {
            // List all the possible books
            Console.WriteLine("Which book would you like to check out?");
            BookRepository bookRepo = new BookRepository();
            List<Book> allBooks = bookRepo.GetAllBooks();
            foreach(Book singleBook in allBooks)
            {
                Console.WriteLine($"{singleBook.Title} - {singleBook.Id}");
            }
            Console.WriteLine(@"Please enter the unique id of the book you want to check out.");

            // Collect the book id
            int bookId = Int32.Parse(Console.ReadLine());

            // List all the possible patrons
            Console.WriteLine(@"Which customer is checking out this book?");
            PatronRepository patronRepo = new PatronRepository();
            List<Patron> allPatrons = patronRepo.GetAllPatrons();
            foreach (Patron singlePatron in allPatrons)
            {
                Console.WriteLine($"{singlePatron.FirstName} {singlePatron.LastName} - {singlePatron.Id}");
            }
            Console.WriteLine(@"Please enter the unique id of the patron.");

            // Collect the patron Id
            int patronId = Int32.Parse(Console.ReadLine());

            // Create a new instance of a PatronBook join table entry
            PatronBook checkedOutBook = new PatronBook()
            {
                PatronId = patronId,
                BookId = bookId,
            };

            // Create the new join table entry in the database
            PatronBookRepository patronBookRepo = new PatronBookRepository();
            patronBookRepo.CheckOutBook(checkedOutBook);

            Console.WriteLine("Congratulations! The book has been checked out.");
            Program.PrintMainMenu();

        }

    }
}
