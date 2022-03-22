#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TugaExchangeWebApp.Data.DbContexts;
using TugaExchangeWebApp.Data.Entities;

namespace TugaExchangeWebApp.Pages.MyCoins
{
    public class EditModel : PageModel
    {
        private readonly TugaExchangeWebApp.Data.DbContexts.ExchangeDbContext _context;

        public EditModel(TugaExchangeWebApp.Data.DbContexts.ExchangeDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Coin Coin { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Coin = await _context.Coins.FirstOrDefaultAsync(m => m.Id == id);

            if (Coin == null)
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

            _context.Attach(Coin).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CoinExists(Coin.Id))
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

        private bool CoinExists(int id)
        {
            return _context.Coins.Any(e => e.Id == id);
        }
    }
}
