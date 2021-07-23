using Microsoft.AspNetCore.Mvc;
using NetworkNinja.Data;
using NetworkNinja.Models;
using System.Collections.Generic;

namespace NetworkNinja.Controllers
{
    public class ForumController : Controller
    {
        private readonly ApplicationDbContext _db;

        public ForumController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<ForumModel> forums = _db.Forums;

            return View(forums);
        }
    }
}
