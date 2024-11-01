using Microsoft.AspNetCore.Mvc;

namespace LibraryOfVermundi.Controllers;

public class SearchController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}