using Microsoft.AspNetCore.Mvc;
using LibraryOfVermundi.Models;

namespace LibraryOfVermundi.Controllers;

public class SearchController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Search()
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
        model.Protected = model.Content.Contains("demon");
        return View("Search", model);
    }
}