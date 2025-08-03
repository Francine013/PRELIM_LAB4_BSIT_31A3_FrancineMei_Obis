using Library_Management_System.Models;
using Microsoft.AspNetCore.Mvc;

namespace Library_Management_System.Controllers
{
    public class LibraryController : Controller
    {//Method rin ito na paglalagyan ng lahat ng added books
        private static Library library = new Library
        {
            LibraryId = 1,
            Location = "Main Library",
            ListOfBooks = new List<Book>()
        };

        public IActionResult Index()
        {
            if (!library.ListOfBooks.Any())
            {
                // 5 Borrowed books (no return date)
                library.ListOfBooks.Add(CreateBook("Ang Mutya ng Section E", "EatMore2BeMoreHappy", Genre.Horror, DateTime.Now, null, new User
                {
                    UserId = 1,
                    FirstName = "France",
                    MiddleName = "P.",
                    LastName = "Obis",
                    Email = "france.obis@example.com"
                }));

                library.ListOfBooks.Add(CreateBook("David Copperfield", "Charles Dickens", Genre.Kids, DateTime.Now, null, new User
                {
                    UserId = 2,
                    FirstName = "Maria",
                    MiddleName = "L.",
                    LastName = "Santos",
                    Email = "maria.santos@example.com"
                }));

                library.ListOfBooks.Add(CreateBook("The Art of Happiness", "Tenzin Gyatso", Genre.SelfHelp, DateTime.Now, null, new User
                {
                    UserId = 3,
                    FirstName = "Carlos",
                    MiddleName = "M.",
                    LastName = "Reyes",
                    Email = "carlos.reyes@example.com"
                }));

                library.ListOfBooks.Add(CreateBook("Legend of Aang", "Aesop", Genre.Fiction, DateTime.Now, null, new User
                {
                    UserId = 4,
                    FirstName = "Nina",
                    MiddleName = "A.",
                    LastName = "Villanueva",
                    Email = "nina.v@example.com"
                }));

                library.ListOfBooks.Add(CreateBook("Juan Tamad", "Tenzin Gyatso", Genre.Kids, DateTime.Now, null, new User
                {
                    UserId = 5,
                    FirstName = "Pedro",
                    MiddleName = "C.",
                    LastName = "Dela Cruz",
                    Email = "pedro.d@example.com"
                }));

                // 2 Returned books
                library.ListOfBooks.Add(CreateBook("Mga Ibong Mandaragit", "Amado V. Hernandez", Genre.Fiction, DateTime.Now.AddDays(-10), DateTime.Now.AddDays(-1), new User
                {
                    UserId = 6,
                    FirstName = "Lea",
                    MiddleName = "G.",
                    LastName = "Salonga",
                    Email = "lea.salonga@example.com"
                }));

                library.ListOfBooks.Add(CreateBook("Dekada '70", "Lualhati Bautista", Genre.History, DateTime.Now.AddDays(-5), DateTime.Now.AddDays(-1), new User
                {
                    UserId = 7,
                    FirstName = "Jose",
                    MiddleName = "D.",
                    LastName = "Rizal",
                    Email = "jose.r@example.com"
                }));

                // 3 Available books (not borrowed)
                library.ListOfBooks.Add(CreateBook("El Filibusterismo", "Jose Rizal", Genre.History, null, null, null));
                library.ListOfBooks.Add(CreateBook("To Kill a Mockingbird", "Harper Lee", Genre.Drama, null, null, null));
                library.ListOfBooks.Add(CreateBook("Noli Me Tangere", "Jose Rizal", Genre.History, null, null, null));
            }

            return View(library);
        }

        public IActionResult AddBook(string title, string authorName, Genre genre)
        {
            var newBook = CreateBook(title, authorName, genre, null, null, null);
            library.ListOfBooks.Add(newBook);
            return RedirectToAction("Index");
        }
        // isa itong method na pinanggagalingan ng lahat ng book dito sa library.
        // sa book id and author id, nag set lang ako kung saang number lang sila pwedeng maglaro para maiwasan yung double number of ID

        private static Book CreateBook(string title, string authorName, Genre genre, DateTime? borrowed, DateTime? returned, User user)
        {
            return new Book
            {
                BookId = new Random().Next(1000, 9999),
                Title = title,
                Author = new Author
                {
                    AuthorId = new Random().Next(1000, 9999),
                    AuthorName = authorName
                },
                Genre = genre,
                BookBorrowed = borrowed,
                ReturnedBook = returned,
                BorrowedBy = user
            };
        }
    }
}
