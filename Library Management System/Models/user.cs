//Itong class na 'to ay nagho-hold ng information ng borrower as temporary storage sa loob ng LibraryController.
namespace Library_Management_System.Models
{
    public class User
    {
        public int UserId { get; set; }

        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }

        public string Email { get; set; }

        public List<Book> BorrowedBooks { get; set; } = new();
// I used this one para kapag naglagay na ako ng laman (last name, first name and middle name) sa controller is 'FullName' nalang yung tatawagin ko sa index.chtml ko
        public string FullName => $"{FirstName} {LastName}";
    }
}
