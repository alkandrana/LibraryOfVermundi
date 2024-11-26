using System.Reflection.Metadata.Ecma335;
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
        Random gen = new Random();
        int max = _context.Entries.Count();
        int id = gen.Next(1, max + 1);
        Entry model = _context.Entries.Find(id);
        return View(model);
    }

    public IActionResult Search()
    {
        return View();
    }

    public IActionResult SearchReader(string key)
    {
        Entry? model = _context.Entries.FirstOrDefault(e => e.Title.Contains(key));
        return View(model);
    }
    
    public IActionResult ContributionForm()
    {
        ViewBag.Categories = _context.Categories.OrderBy(c => c.Name).ToList();
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