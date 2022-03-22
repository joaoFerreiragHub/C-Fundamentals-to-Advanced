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
    public class DetailsModel : PageModel
    {
        private readonly BiblioApp.Data.DbContexts.BiblioDbContext _context;

        public DetailsModel(BiblioApp.Data.DbContexts.BiblioDbContext context)
        {
            _context = context;
        }

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
    }
}
