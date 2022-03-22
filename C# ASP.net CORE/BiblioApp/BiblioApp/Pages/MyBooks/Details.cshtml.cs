using BiblioApp.Data.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace BiblioApp.Pages.MyBooks
{
    public class DetailsModel : PageModel
    {
        private readonly BiblioApp.Data.DbContexts.BiblioDbContext _context;

        public DetailsModel(BiblioApp.Data.DbContexts.BiblioDbContext context)
        {
            _context = context;
        }

        public Book Book { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Book = await _context.Books
                .Include(b => b.Country).FirstOrDefaultAsync(m => m.Id == id);

            if (Book == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
