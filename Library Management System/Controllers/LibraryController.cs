using Library_Management_System.Models;
using Microsoft.AspNetCore.Mvc;

namespace Library_Management_System.Controllers
{
    public class LibraryController : Controller
    {
        public IActionResult Index()
        {
            var library = new library();
            library.ListOfBooks.Add(NewMethod("Ang Mutya ng Section E", "eatMore2bemorehappy", null, "Horror", null, null));
            library.ListOfBooks.Add(NewMethod("David Copperfield", "Charles Dickens", null, "Kids", null, null));
            library.ListOfBooks.Add(NewMethod("The Art of Happiness", "Tenzin Gyatso", null, "Self Help", null, null));
            library.ListOfBooks.Add(NewMethod("Legend of Aang", "Aesop", null, "Fiction", null, null));
            library.ListOfBooks.Add(NewMethod("Juan Tamad", "Tenzin Gyatso", null, "Kids", null, null));



            return View(library);
        }

        private static book NewMethod(string title, string authorname, DateTime? Birthdate, string Genre, DateTime? bookborrowed, DateTime? returnedbook)
        {
            return new book
            {
                Title = title,
                author = new author
                {
                    AuthorName = authorname,
                    Birthdate = new DateTime()
                },
                BookBorrowed = bookborrowed,
                ReturnedBook = returnedbook,
                Genre = Genre

            };
        }
    }
}
