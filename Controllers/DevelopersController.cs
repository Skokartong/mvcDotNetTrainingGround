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
    }
}