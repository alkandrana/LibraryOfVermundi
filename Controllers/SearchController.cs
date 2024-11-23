using LibraryOfVermundi.Data;
using Microsoft.AspNetCore.Mvc;
using LibraryOfVermundi.Models;

namespace LibraryOfVermundi.Controllers;

public class SearchController : Controller
{
    private AppDbContext _context;

    public SearchController(AppDbContext ctx)
    {
        _context = ctx;
    }
    // GET
    public IActionResult Index()
    {
        List<Entry> model = _context.Entries.ToList();
        return View(model);
    }
    
    public IActionResult ContributionForm()
    {
        return View();
    }

    [HttpPost]
    public IActionResult ContributionForm(Entry model)
    {
        model.SubmissionDate = DateTime.Now;
        _context.Entries.Add(model);
        _context.SaveChanges();
        return RedirectToAction("Index");
    }
}