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
    }
}

