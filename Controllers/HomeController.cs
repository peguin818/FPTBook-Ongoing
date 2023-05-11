using Microsoft.AspNetCore.Mvc;
using FPTBook.Models;
using System.Diagnostics;
using Microsoft.EntityFrameworkCore;
using FPTBook.Models.ViewModels;

namespace FPTBook.Controllers;

public class HomeController : Controller
{
    private IStoreRepository repository;
    public int PageSize = 4;
    public HomeController(IStoreRepository repo)
    {
        repository = repo;
    }
    public ViewResult Index(string? category, int productPage = 1)
        => View(new BooksListViewModel
        {
            Books = repository.Books
                .Where(p => category == null || p.Category == category)
                .OrderBy(p => p.BookID)
                .Skip((productPage - 1) * PageSize)
                .Take(PageSize),
            PagingInfo = new PagingInfo
            {
                CurrentPage = productPage,
                ItemsPerPage = PageSize,
                TotalItems = category == null
                    ? repository.Books.Count()
                    : repository.Books.Where(e =>
                        e.Category == category).Count()
            },
            CurrentCategory = category
        });
}
