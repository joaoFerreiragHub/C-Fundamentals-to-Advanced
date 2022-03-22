#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using TugaExchangeWebApp.Data.DbContexts;
using TugaExchangeWebApp.Data.Entities;

namespace TugaExchangeWebApp.Pages.MyCoins
{
    public class CreateModel : PageModel
    {
        private readonly TugaExchangeWebApp.Data.DbContexts.ExchangeDbContext _context;

        public CreateModel(TugaExchangeWebApp.Data.DbContexts.ExchangeDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Coin Coin { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Coins.Add(Coin);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
