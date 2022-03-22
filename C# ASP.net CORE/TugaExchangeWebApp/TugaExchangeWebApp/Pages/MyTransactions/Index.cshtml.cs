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

namespace TugaExchangeWebApp.Pages.MyTransactions
{
    public class IndexModel : PageModel
    {
        private readonly TugaExchangeWebApp.Data.DbContexts.ExchangeDbContext _context;

        public IndexModel(TugaExchangeWebApp.Data.DbContexts.ExchangeDbContext context)
        {
            _context = context;
        }

        public IList<Transaction> Transaction { get;set; }

        public async Task OnGetAsync()
        {
            Transaction = await _context.transactions
                .Include(t => t.User)
                .Include(t => t.Coin).ToListAsync();
        }
    }
}
