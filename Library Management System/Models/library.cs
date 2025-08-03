namespace Library_Management_System.Models
{    // Dito ini-store o iniipon lahat ng listahan ng mga libro na meron sa library.
    // Isa itong class na nagre-represent sa mismong library
    public class Library
    {
        public int LibraryId { get; set; }

        public string Location { get; set; }

        public List<Book> ListOfBooks { get; set; } = new();
    }
}
