using Microsoft.AspNetCore.Mvc;
using FPTBook.Models;
using System.Diagnostics;
using Microsoft.EntityFrameworkCore;
using FPTBook.Models.ViewModels;

namespace FPTBook.Controllers;

public class ProductController : Controller
{
    private IStoreRepository repository;
    public int PageSize = 4;
    public ProductController(IStoreRepository repo)
    {
        repository = repo;
    }
    public ViewResult Index(int productPage = 1)
        => View(new BooksListViewModel
        {
            Books = repository.Books
                .OrderBy(p => p.BookID)
                .Skip((productPage - 1) * PageSize)
                .Take(PageSize),
            PagingInfo = new PagingInfo
            {
                CurrentPage = productPage,
                ItemsPerPage = PageSize,
                TotalItems = repository.Books.Count()
            }
        });
}