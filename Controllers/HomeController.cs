using Microsoft.AspNetCore.Mvc;
using FPTBook.Models;
using System.Diagnostics;
using Microsoft.EntityFrameworkCore;
using FPTBook.Models.ViewModels;

namespace FPTBook.Controllers;

public class HomeController : Controller
{
    private IStoreRepository repository;
    public HomeController(IStoreRepository repo)
    {
        repository = repo;
    }

    public IActionResult Index()
    {
        return View(repository.Books.Take(4));
    }
}
