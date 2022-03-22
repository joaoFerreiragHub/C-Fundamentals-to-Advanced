#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using TugaExchangeWebApp.Data.DbContexts;
using TugaExchangeWebApp.Data.Entities;

namespace TugaExchangeWebApp.Pages.MyCoins
{
    public class DetailsModel : PageModel
    {
        private readonly TugaExchangeWebApp.Data.DbContexts.ExchangeDbContext _context;

        public DetailsModel(TugaExchangeWebApp.Data.DbContexts.ExchangeDbContext context)
        {
            _context = context;
        }

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
    }
}
