using System.ComponentModel.DataAnnotations;

namespace Mini_Library_Management.Models.Domain
{
    public class Book
    {
        public int BookId { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }
        public string Category { get; set; }
        public int CopiesAvailable { get; set; }
        public int PublishedYear { get; set; }
        public bool Status { get; set; }
    }
}
