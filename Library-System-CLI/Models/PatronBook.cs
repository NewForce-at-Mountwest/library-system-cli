using System;

namespace Library_System_CLI.Models
{
    public class PatronBook
    {
        public int Id { get; set; }

        public int PatronId { get; set; }
        public Patron Patron { get; set; }
        public Book Book { get; set; }

        public int BookId { get; set; }

        public string DueDate { get; set; } = DateTime.Now.AddDays(14).ToString("yyyy-MM-dd HH:mm:ss.fff");

    }
}