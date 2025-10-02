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
            ViewData["Developers"] = _db.Developers;
            return View();
        }
    }
}