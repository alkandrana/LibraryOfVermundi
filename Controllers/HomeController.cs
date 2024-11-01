using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using LibraryOfVermundi.Models;

namespace LibraryOfVermundi.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

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
}