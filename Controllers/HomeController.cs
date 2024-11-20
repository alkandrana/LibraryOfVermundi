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