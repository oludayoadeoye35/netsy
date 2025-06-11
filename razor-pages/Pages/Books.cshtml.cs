using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace razor_pages_challenges.Pages
{
    public class BooksModel : PageModel
    {

        public string BestBooks =[
            "The Great Gatsby",
            "To Kill a Mockingbird",
            "1984",
            "Pride and Prejudice",
            "The Catcher in the Rye"
        ];
        public void OnGet()
        {
        }
    }
}
