using System;
using System.Collections.Generic;

namespace Library_System_CLI.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Author { get; set; }
        public string Title { get; set; }

        public List<PatronBook> currentPatrons { get; set; } = new List<PatronBook>();
        
    }
}