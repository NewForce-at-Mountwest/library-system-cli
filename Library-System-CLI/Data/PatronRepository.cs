using System.Collections.Generic;
using System.Data.SqlClient;
using Library_System_CLI.Models;

namespace Library_System_CLI
{

    public class PatronRepository
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




        public List<Patron> GetAllPatrons()
        {

            using (SqlConnection conn = Connection)
            {
                conn.Open();

                using (SqlCommand cmd = conn.CreateCommand())
                {

                    cmd.CommandText = "SELECT Id, FirstName, LastName FROM Patron";


                    SqlDataReader reader = cmd.ExecuteReader();


                    List<Patron> patrons = new List<Patron>();


                    while (reader.Read())
                    {
                        // For each row that comes back from the database, create a new instance of a book
                        Patron patron = new Patron
                        {
                            Id = reader.GetInt32(reader.GetOrdinal("Id")),
                            FirstName = reader.GetString(reader.GetOrdinal("FirstName")),
                            LastName = reader.GetString(reader.GetOrdinal("LastName"))
                        };
                        // Add your new instance of a book to the list
                        patrons.Add(patron);
                    }
                    reader.Close();
                    return patrons;
                }
            }
        }
    }
}

