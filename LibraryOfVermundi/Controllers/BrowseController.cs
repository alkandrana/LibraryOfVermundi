using LibraryOfVermundi.Data;
using Microsoft.AspNetCore.Mvc;
using LibraryOfVermundi.Models;
using Microsoft.EntityFrameworkCore;

namespace LibraryOfVermundi.Controllers;

public class BrowseController : Controller
{
    private IEntryRepository _repo;

    public BrowseController(IEntryRepository r)
    {
        _repo = r;
    }
    // GET
    public IActionResult Index()
    {
        var categories = _repo.GetAllCategories("complex");

        return View(categories);
     }
    [HttpGet]
    public IActionResult Reader(int id)
    {
        Entry? model = _repo.GetEntryById(id);
        return View(model);
    }

    public IActionResult Edit(int id)
    {
        List<Category> categories = _repo.GetAllCategories("simple");
        Entry entry = _repo.GetEntryById(id);
        ViewBag.Categories = categories;
        return View("Editor", entry);
    }

    [HttpPost]
    public IActionResult Edit(Entry model)
    {
        if (_repo.UpdateEntry(model) > 0)
        {
            return RedirectToAction("Index");
        }
        ViewBag.Categories = _repo.GetAllCategories("simple");
        return View("Editor", model);
    }
}