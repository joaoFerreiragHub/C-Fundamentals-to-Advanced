using BiblioApp.Data.Entities;

namespace BiblioApp.Services;

public class BookService : IBookStore
{
    private static List<Book> _books;

    static BookService()
    {
        _books = new List<Book>();
        //  _books.Add(new Book("Eat to Beat Disease", "1193-76878-87989", "Li"));
    }

    public void AddBook(string title, string isbn, string authors)
    {
        var book = new Book()
        {
            // Authors = authors,
            Title = title,
            ISBN = isbn
        };

        _books.Add(book);
    }

    public void AddBook(string title, string isbn, string shortDescription, bool isHardCover)
    {
        throw new NotImplementedException();
    }

    public void AddBook(Book book)
    {
        _books.Add(book);
    }

    public Task AddBookAsync(Book book)
    {
        throw new NotImplementedException();
    }

    public List<Book> GetAllBooks()
        => _books;
}