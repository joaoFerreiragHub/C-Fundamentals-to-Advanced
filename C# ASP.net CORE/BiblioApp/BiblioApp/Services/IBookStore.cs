using BiblioApp.Data.Entities;

namespace BiblioApp.Services;

public interface IBookStore
{
    void AddBook(string title, string isbn, string shortDescription, bool isHardCover);
    void AddBook(Book book);
    Task AddBookAsync(Book book);
    List<Book> GetAllBooks();
}