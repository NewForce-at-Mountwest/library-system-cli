using System.Collections.Generic;
using System.Data.SqlClient;
using Library_System_CLI.Models;

namespace Library_System_CLI
{

    public class PatronBookRepository
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

        public void CheckOutBook(PatronBook patronBook)
        {
            using (SqlConnection conn = Connection)
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    // Insert a new entry into the join table based on the PatronBook instance we passed in
                    cmd.CommandText = $"INSERT INTO PatronBook (BookId, PatronId) Values ({patronBook.BookId}, {patronBook.PatronId})";

                    // Execute the command-- create the thing!
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}

