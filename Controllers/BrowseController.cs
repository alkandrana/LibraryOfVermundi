using Microsoft.AspNetCore.Mvc;

namespace LibraryOfVermundi.Controllers;

public class BrowseController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Topics()
    {
        return View();
    }
}