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
        {   // For each category, generate a random number and use it to select an
            // article from that category to base one of the five quiz questions on
            Random gen = new Random();
            List<Entry> entries = _repo.GetAllEntries();
            List<string> categories = entries.Select(c => c.CategoryId).Distinct().ToList();
            QuizVM model = new QuizVM();
            foreach (string id in categories)
            {
                List<Entry> source = entries.Where(e => e.CategoryId == id).ToList();
                int max = source.Count;
                int select = gen.Next(0, max);
                Question q = new Question(source[select]);
                q.Query = q.MakeQuestion();
                model.Questions.Add(q);
            }
            
            return View(model);
        }

        [HttpPost]
        public IActionResult Trivia(QuizVM model, string[] answer, int[] id, string[] query)
        {
            for (int i = 0; i < answer.Length; i++)
            {
                Entry source = _repo.GetEntryById(id[i]);
                model.Questions.Add(new Question(source));
                model.Questions[i].UserAnswer = answer[i];
                model.Questions[i].Query = query[i];
            }
            return View(model);
        }
    }
}