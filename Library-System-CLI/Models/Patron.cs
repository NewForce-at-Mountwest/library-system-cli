
using System.Collections.Generic;

namespace Library_System_CLI.Models
{
    public class Patron
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public List<PatronBook> CheckedOutBooks { get; set; } = new List<PatronBook>();

    }
}