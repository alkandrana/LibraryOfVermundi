using LibraryOfVermundi.Data;
using Microsoft.AspNetCore.Mvc;
using LibraryOfVermundi.Models;
using Microsoft.EntityFrameworkCore;

namespace LibraryOfVermundi.Controllers;

public class BrowseController : Controller
{
    private AppDbContext _context;

    public BrowseController(AppDbContext ctx)
    {
        _context = ctx;
    }
    // GET
    public IActionResult Index()
    {
        var categories = _context.Entries.Include(
            e => e.Category).ToList();

        return View(categories);
    }
    [HttpGet]
    public IActionResult Reader(int id)
    {
        Entry? model = _context.Entries.Find(id);
        return View(model);
    }
}