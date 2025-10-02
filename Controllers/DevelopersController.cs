namespace mvcDotNetTrainingGround.Controllers
{
    using System.Data.Common;
    using Microsoft.AspNetCore.Mvc;
    using mvcDotNetTrainingGround.Models;

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

        public IActionResult Create()
        {
            return View();
        }
    }
}