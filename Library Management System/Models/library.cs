namespace Library_Management_System.Models
{
    public class library
    {
        public string Location { get; set; }
        public List<book> ListOfBooks { get; set; } = [];
    }
}
