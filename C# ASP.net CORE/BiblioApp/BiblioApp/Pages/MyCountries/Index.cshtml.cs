namespace BiblioApp.Pages.MyCountries;

public class IndexModel : PageModel
{
    private readonly Data.DbContexts.BiblioDbContext _context;

    public IndexModel(Data.DbContexts.BiblioDbContext context)
    {
        _context = context;
    }

    public IList<Country> Country { get; set; }

    public async Task OnGetAsync()
    {
        Country = await _context.Countries.ToListAsync();
    }
}