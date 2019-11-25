using System.Collections.Generic;
using System.Data.SqlClient;
using Library_System_CLI.Models;

namespace Library_System_CLI
{

    public class BookRepository
    {

        public SqlConnection Connection
        {
            get
            {
                // This is "address" of the database
                string _connectionString = "Server=localhost\\SQLEXPRESS;Database=Library-System;Trusted_Connection=True";
                return new SqlConnection(_connectionString);
            }
        }




        public List<Book> GetAllBooks()
        {

            using (SqlConnection conn = Connection)
            {
                conn.Open();

                using (SqlCommand cmd = conn.CreateCommand())
                {

                    cmd.CommandText = "SELECT Id, Title, Author FROM Book";


                    SqlDataReader reader = cmd.ExecuteReader();


                    List<Book> books = new List<Book>();

                    while (reader.Read())
                    {
                        // For each row that comes back from the database, create a new instance of a book
                        Book book = new Book
                        {
                            Id = reader.GetInt32(reader.GetOrdinal("Id")),
                            Title = reader.GetString(reader.GetOrdinal("Title")),
                            Author = reader.GetString(reader.GetOrdinal("Author"))
                        };
                        // Add your new instance of a book to the list
                        books.Add(book);
                    }
                    reader.Close();
                    return books;
                }
            }
        }

        public Book GetSingleBookStatus(int id)
        {

            using (SqlConnection conn = Connection)
            {
                conn.Open();

                using (SqlCommand cmd = conn.CreateCommand())
                {

                    cmd.CommandText = @"SELECT Book.Id, Book.Title, Book.Author, 
                        Patron.FirstName, Patron.LastName FROM Book
                        JOIN PatronBook ON PatronBook.BookId = Book.Id
                        JOIN Patron ON PatronBook.PatronId = Patron.Id WHERE Book.Id=@id";

                    cmd.Parameters.Add(new SqlParameter("@id", id));

                    SqlDataReader reader = cmd.ExecuteReader();


                    Book book = new Book();

                    while (reader.Read())
                    {
                        // If we haven't already assigned the book's info, assign the book's info
                        // This conditional should only be true on the first row of data that comes back 
                        if(book.Id == 0)
                        {
                            book.Id = reader.GetInt32(reader.GetOrdinal("Id"));
                            book.Title = reader.GetString(reader.GetOrdinal("Title"));
                            book.Author = reader.GetString(reader.GetOrdinal("Author"));
                        };

                        // If multiple patrons have checked out the book, we want to create a new instance of PatronBook for each one and add their first and last name
                        PatronBook currentPatron = new PatronBook
                        {
                            Patron = new Patron()
                            {
                                FirstName = reader.GetString(reader.GetOrdinal("FirstName")),
                                LastName = reader.GetString(reader.GetOrdinal("LastName"))
                            }
                        };

                        // Then we add the new instance to the book's list of patrons

                        book.Patrons.Add(currentPatron);
                            
                    }
                    reader.Close();
                    return book;
                }
            }
        }
    }
}

