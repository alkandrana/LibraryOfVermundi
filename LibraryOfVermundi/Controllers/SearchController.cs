using System.Reflection.Metadata.Ecma335;
using LibraryOfVermundi.Data;
using Microsoft.AspNetCore.Mvc;
using LibraryOfVermundi.Models;

namespace LibraryOfVermundi.Controllers;

public class SearchController : Controller
{
    private IEntryRepository _repo;

    public SearchController(IEntryRepository r)
    {
        _repo = r;
    }
    // GET
    public IActionResult Index()
    {
        Random gen = new Random();
        List<Entry> entries = _repo.GetAllEntries();
        int max = entries.Count();
        int id = gen.Next(1, max + 1);
        Entry? model = _repo.GetEntryById(id);
        return View(model);
    }

    public IActionResult Search()
    {
        return View();
    }
    // Search function
    public IActionResult SearchReader(string key)
    {
        var entries = _repo.GetAllEntries();
        var model = entries.FirstOrDefault(e => e.Title.ToLower().Contains(key.ToLower()));
        return View(model);
    }
    
    public IActionResult ContributionForm()
    {
        ViewBag.Contributors = _repo.GetAllUsers();
        ViewBag.Categories = _repo.GetAllCategories("simple");
        return View();
    }

    [HttpPost]
    public IActionResult ContributionForm(Entry model)
    {
        if(_repo.StoreEntry(model) > 0)
        {
            return RedirectToAction("Index");
        }

        ViewBag.ErrorMessage = "There was a problem submitting your entry.";
        return View();
    }

    public IActionResult Register()
    {
        return View("NewUser");
    }

    [HttpPost]
    public IActionResult Register(AppUser model)
    {
        if (_repo.StoreAppUser(model) > 0)
        {
            return RedirectToAction("ContributionForm");
        }
        ViewBag.ErrorMessage = "There was a problem submitting your profile.";
        return View("NewUser", model);
    }
}