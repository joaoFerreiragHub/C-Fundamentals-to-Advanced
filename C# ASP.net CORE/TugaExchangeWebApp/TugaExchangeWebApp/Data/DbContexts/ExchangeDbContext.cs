using Microsoft.EntityFrameworkCore;
using TugaExchangeWebApp.Data.Entities;

namespace TugaExchangeWebApp.Data.DbContexts
{
    public class ExchangeDbContext : DbContext
    {

        public ExchangeDbContext(DbContextOptions<ExchangeDbContext> options) : base(options)
        {
               
        }

        public DbSet<Coin> Coins { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Transaction> transactions { get; set; }

    }
}
