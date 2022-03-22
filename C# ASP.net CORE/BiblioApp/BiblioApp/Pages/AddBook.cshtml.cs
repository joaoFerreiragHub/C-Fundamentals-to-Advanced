using BiblioApp.Data.Entities;
using BiblioApp.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BiblioApp.Pages;

public class AddBookModel : PageModel
{
    private readonly IBookStore _bookService;

    public AddBookModel(IBookStore bookService)
    {
        _bookService = bookService;
    }

    [BindProperty]
    public Book Book { get; set; }

    public void OnGet()
    {
    }

    public void OnPost()
    {
        Book.IsHardCover = true;
        _bookService.AddBook(Book);
    }
}