namespace Library_Management_System.Models
{
    public class book
    {
        public string Title { get; set; }
        public author author { get; set; }
        public string Genre { get; set; }
        public DateTime? BookBorrowed { get; set; }
        public DateTime? ReturnedBook {  get; set; }
    }
    public enum Genre
    {
        Thriller,
        Horror,
        action,
        Kids,
        Comedy
    }
}
