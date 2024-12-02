using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using LibraryOfVermundi.Data;
using LibraryOfVermundi.Models;

namespace LibraryOfVermundi.Controllers
{
    public class HomeController : Controller
    {
        private IEntryRepository _repo;
        public HomeController(IEntryRepository r)
        {
            _repo = r;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Trivia()
        {
            List<Category> categories = _repo.GetAllCategories("simple");
            ViewBag.Categories = categories;
            return View();
        }

        [HttpPost]
        public IActionResult Trivia(Category category)
        {
            if (category.CategoryId == "B")
            {
                List<Entry> biographies = _repo.GetEntriesByCategory("B");
                List<string> dynasts = new List<string>();
                foreach (Entry b in biographies)
                {
                    dynasts.Add("Name the era of " + b.Title.Substring(0, b.Title.IndexOf(" ")));
                }
            }
            return View();
        }

        


    }
}