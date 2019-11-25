using Library_System_CLI.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Library_System_CLI.Actions
{
    class CheckBookStatus
    {
        public static void CollectInput()
        {
            BookRepository bookRepo = new BookRepository();

            // TODO: this is almost identical to the code we had to write to list all the books in CheckOutBook. Can we refactor so that we only write this code once? 

            // List all the possible books
            Console.WriteLine("Which book's status would you like to see?");
            List<Book> allBooks = bookRepo.GetAllBooks();
            foreach (Book singleBook in allBooks)
            {
                Console.WriteLine($"{singleBook.Title} - {singleBook.Id}");
            }
            Console.WriteLine(@"Please enter the unique id of the book you want to see.");

            // Collect the book id
            int bookId = Int32.Parse(Console.ReadLine());

            // Get the book details
            Book bookDetails = bookRepo.GetSingleBookStatus(bookId);

            // Print the book details
            Console.WriteLine($@"

Here's the book's current information: 

Title: {bookDetails.Title}

Author: {bookDetails.Author}

People who currently have this book checked out:
            ");

            // Print the patrons who currently have this book checked out
            bookDetails.Patrons.ForEach(patronBook => Console.WriteLine($"{patronBook.Patron.FirstName} {patronBook.Patron.LastName}"));

            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
            Program.PrintMainMenu();

        }
    }
}
