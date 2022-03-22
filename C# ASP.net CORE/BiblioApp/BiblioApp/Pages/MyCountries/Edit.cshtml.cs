using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BiblioApp.Data.DbContexts;
using BiblioApp.Data.Entities;

namespace BiblioApp.Pages.MyCountries
{
    public class EditModel : PageModel
    {
        private readonly BiblioApp.Data.DbContexts.BiblioDbContext _context;

        public EditModel(BiblioApp.Data.DbContexts.BiblioDbContext context)
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

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Country).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CountryExists(Country.Code))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool CountryExists(string id)
        {
            return _context.Countries.Any(e => e.Code == id);
        }
    }
}
