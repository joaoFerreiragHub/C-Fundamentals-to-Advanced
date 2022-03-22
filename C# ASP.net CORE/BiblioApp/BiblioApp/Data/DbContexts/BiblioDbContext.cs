using BiblioApp.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace BiblioApp.Data.DbContexts;

public class BiblioDbContext : DbContext
{
    public DbSet<Book> Books { get; set; }
    public DbSet<Country> Countries { get; set; }

    public BiblioDbContext(DbContextOptions<BiblioDbContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Book>().Property(p => p.CountryCode).HasMaxLength(5);
        modelBuilder.Entity<Country>().Property(p => p.Code).HasMaxLength(5);
        modelBuilder.Entity<Book>().HasIndex(p=> p.ISBN);
    }
}