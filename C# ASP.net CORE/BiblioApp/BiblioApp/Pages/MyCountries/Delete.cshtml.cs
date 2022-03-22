using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BiblioApp.Data.DbContexts;
using BiblioApp.Data.Entities;

namespace BiblioApp.Pages.MyCountries
{
    public class DeleteModel : PageModel
    {
        private readonly BiblioApp.Data.DbContexts.BiblioDbContext _context;

        public DeleteModel(BiblioApp.Data.DbContexts.BiblioDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Country Country { get; set; }

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Country = await _context.Countries.FirstOrDefaultAsync(m => m.Code == id);

            if (Country == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Country = await _context.Countries.FindAsync(id);

            if (Country != null)
            {
                _context.Countries.Remove(Country);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
