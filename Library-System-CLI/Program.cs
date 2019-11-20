using Library_System_CLI.Actions;
using Library_System_CLI.Models;
using System;
using System.Collections.Generic;

namespace Library_System_CLI
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintMainMenu();
        }

        public static void PrintMainMenu()
        {
            Console.WriteLine(@"Welcome to the Huntington Library System
 Please select an option:
               
1. Check out a book
2. Return a book
3. View patrons who currently have checked out books
4. Make a new patron
5. Check patron status
6. Delete a patron
7. Edit a patron's information
8. View reports
            
");
            string input = Console.ReadLine();

            switch (Int32.Parse(input))
            {
                case 1:
                    CheckOutBook.CollectInput();
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    break;
                case 5:
                    break;
                case 6:
                    break;
                case 7:
                    break;
                case 8:
                    break;
                default:
                    Console.WriteLine("Please select a valid option.");
                    PrintMainMenu();
                    break;
            };
        }
    }
}
