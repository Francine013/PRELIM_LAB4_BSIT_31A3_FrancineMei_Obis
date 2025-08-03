namespace Library_Management_System.Models
{// itong class na ito naman is humahawak sa lahat ng information sa libro, kung sinong author, title, genre, kaialan hiniram at ibinalik.
    //Nakalink din ito sa User (borrower) na humiram ng book.
    public class Book
    {
        public int BookId { get; set; }
        public string Title { get; set; }
        public Author Author { get; set; }
        public Genre Genre { get; set; }
        public DateTime? BookBorrowed { get; set; }
        public DateTime? ReturnedBook { get; set; }
        public User BorrowedBy { get; set; }
    }
    // I numerate the genres that are available in this library para less hassle sa pagdeclare and pagtawag sa LibrarayController

    public enum Genre
    {
        Thriller,
        Horror,
        Action,
        Kids,
        Comedy,
        Fiction,
        SelfHelp,
        History,
        Drama
    }
}
