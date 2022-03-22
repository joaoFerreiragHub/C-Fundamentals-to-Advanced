using BiblioApp.Data.Entities;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace BiblioApp.Pages.MyBooks
{
    public class IndexModel : PageModel
    {
        private readonly BiblioApp.Data.DbContexts.BiblioDbContext _context;

        public IndexModel(BiblioApp.Data.DbContexts.BiblioDbContext context)
        {
            _context = context;
        }

        public IList<Book> Book { get;set; }

        public async Task OnGetAsync()
        {
            Book = await _context.Books
                .Include(b => b.Country).ToListAsync();
        }
    }
}
