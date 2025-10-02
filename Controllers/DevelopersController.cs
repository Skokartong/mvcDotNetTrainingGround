namespace mvcDotNetTrainingGround.Controllers
{
    using System.Data.Common;
    using Microsoft.AspNetCore.Mvc;
    using mvcDotNetTrainingGround.Models;
    using webApiDotNetTrainingGround.Models;

    public class DevelopersController : Controller
    {
        private Db _db;

        public DevelopersController(Db db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            return View(_db.Developers);
        }

        public IActionResult Details(int id)
        {
            var developer = _db.Developers.FirstOrDefault(d => d.Id == id);
            if (developer == null)
            {
                return NotFound();
            }
            return View(developer);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(CreateDeveloperRequest request)
        {
            if (!ModelState.IsValid)
            {
                return View(request);
            }

            var newDeveloper = new Developer
            {
                Id = _db.Developers.Max(d => d.Id) + 1,
                Name = request.Name!,
                Role = request.Role!,
                Experience = request.Experience!.Value
            };

            _db.Developers.Add(newDeveloper);

            return RedirectToAction("Index");
        }
    }
}