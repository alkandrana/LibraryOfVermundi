using Microsoft.AspNetCore.Mvc;
using LibraryOfVermundi.Models;

namespace LibraryOfVermundi.Controllers;

public class SearchController : Controller
{
    // GET
    public IActionResult Index()
    {
        Entry model = new Entry();
        model.Contributor = new AppUser();
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
        return View("Index", model);
    }
}