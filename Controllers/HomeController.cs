using Microsoft.AspNetCore.Mvc;
using FPTBook.Models;
using System.Diagnostics;
using FPTBook.Models.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace FPTBook.Controllers;

public class HomeController : Controller
{
    private readonly StoreIdentityDbContext _context;

    public HomeController(StoreIdentityDbContext context)
    {
        _context = context;
    }

    public async Task<IActionResult> Index()
    {
        var FPTBookContext = _context.Books.Include(b => b.Author).Include(b => b.Category);
        return View(await FPTBookContext.ToListAsync());
    }

    public async Task<IActionResult> Product(string searchString)
    {
        var book = from m in _context.Books.Include(b => b.Author).Include(b => b.Category)
                   select m;
        var book1 = _context.Books.Include(b => b.Author).Include(b => b.Category);
        if (!String.IsNullOrEmpty(searchString))
        {
            book = book.Where(s => s.Name!.Contains(searchString));
        }
        return View(await book.ToListAsync());
    }

    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
    public async Task<IActionResult> Detail(int? id)
    {
        if (id == null || _context.Books == null)
        {
            return NotFound();
        }
        var book = await _context.Books
            .Include(b => b.Author)
            .Include(b => b.Category)
            .FirstOrDefaultAsync(m => m.BookID == id);
        if (book == null)
        {
            return NotFound();
        }
        return View(book);
    }
}
