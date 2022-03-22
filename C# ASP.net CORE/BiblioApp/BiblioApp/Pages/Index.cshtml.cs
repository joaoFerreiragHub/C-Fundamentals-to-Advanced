using BiblioApp.Data.Entities;
using BiblioApp.Services;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BiblioApp.Pages
{
    public class IndexModel : PageModel
    {
        private readonly IBookStore _bookservice;

        public IndexModel(IBookStore bookservice)
        {
            _bookservice = bookservice;
        }

        public List<Book> Books { get; set; }
        public void OnGet()
        {
            Books = _bookservice.GetAllBooks();
        }
    }
}