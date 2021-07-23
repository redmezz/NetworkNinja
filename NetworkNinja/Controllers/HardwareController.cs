using Microsoft.AspNetCore.Mvc;
using NetworkNinja.Data;

namespace NetworkNinja.Controllers
{
    public class HardwareController : Controller
    {
        private readonly ApplicationDbContext _db;

        public HardwareController(ApplicationDbContext db)
        {
            _db = db;
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(HardwareController hardware)
        {
            _db.Add(hardware);
            _db.SaveChanges();
            return RedirectToRoute("[controller=Forum]/[action=Index]");
        }

        public IActionResult CAC()
        {
            return View();
        }
    }
}
