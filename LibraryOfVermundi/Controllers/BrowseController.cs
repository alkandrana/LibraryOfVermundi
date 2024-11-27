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
        var categories = _repo.GetAllEntries();

        return View(categories);
    }
    [HttpGet]
    public IActionResult Reader(int id)
    {
        Entry? model = _repo.GetEntryById(id);
        return View(model);
    }
}