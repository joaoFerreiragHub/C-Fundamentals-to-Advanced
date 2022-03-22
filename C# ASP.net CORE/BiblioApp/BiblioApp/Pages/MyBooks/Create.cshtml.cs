using BiblioApp.Data.Entities;
using BiblioApp.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BiblioApp.Pages.MyBooks
{
    public class CreateModel : PageModel
    {
        private readonly BiblioApp.Data.DbContexts.BiblioDbContext _context;
        private readonly IBookStore _bookDbService;

        public CreateModel(BiblioApp.Data.DbContexts.BiblioDbContext context
            , IBookStore bookDbService)
        {
            _context = context;
            _bookDbService = bookDbService;
        }

        public IActionResult OnGet()
        {
            ViewData["CountryCode"] = new SelectList(_context.Countries, "Code", "Name");

            return Page();
        }

        [BindProperty]
        public Book Book { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                ViewData["CountryCode"] = new SelectList(_context.Countries, "Code", "Name");
                return Page();
            }

            //_bookDbService.AddBook(Book);
            await _bookDbService.AddBookAsync(Book);

            return RedirectToPage("./Index");
        }
    }
}
