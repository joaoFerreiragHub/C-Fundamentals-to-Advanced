using BiblioApp.Data.DbContexts;
using BiblioApp.Data.Entities;

namespace BiblioApp.Services;

public class BookDbService : IBookStore
{
    private readonly BiblioDbContext _ctx;

    public BookDbService(BiblioDbContext ctx)
    {
        _ctx = ctx;
    }

    public void AddBook(string title, string isbn, string shortDescription, bool isHardCover)
    {
        var book = new Book
        {
            Title = title,
            ISBN = isbn,
            IsHardCover = isHardCover,
            ShortDescription = shortDescription,
        };

        AddBook(book);
    }

    public void AddBook(Book book)
    {
        _ctx.Books.Add(book);
        _ctx.SaveChanges();
    }

    public async Task AddBookAsync(Book book)
    {
        _ctx.Books.Add(book);
        await _ctx.SaveChangesAsync();
    }

    public List<Book> GetAllBooks()
    {
        return _ctx.Books.Skip(1).Take(3).ToList();
    }
}