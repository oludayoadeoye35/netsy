using Microsoft.AspNetCore.Mvc;
using books_mvc.Models;

namespace books_mvc.Controllers
{
    public class BooksController : Controller
    {
        // GET: BooksController
        public ActionResult Index()
        {
            var books = new Books();
            return View("allbooks", books);
        }


        //favourite book
        public ActionResult FavouriteBook()
        {
            var books = new Books();
            return View(books);
        }

    }
}
