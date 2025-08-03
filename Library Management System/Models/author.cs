// ito is conncted don sa Book.cs para makuha yung info about s Author
 namespace Library_Management_System.Models
{
    public class Author
    {
        public int AuthorId { get; set; }

        public string AuthorName { get; set; }


        public List<Book> Books { get; set; } = new();
    }
}
