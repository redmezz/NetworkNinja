using Microsoft.AspNetCore.Mvc;

namespace NetworkNinja.Controllers
{
    public class AdministrationController : Controller
    {
        public IActionResult Forms()
        {
            return View();
        }

        public IActionResult InProcessing()
        {
            return View();
        }

        public IActionResult OutProcessing()
        {
            return View();
        }

        public IActionResult Bookmarks()
        {
            return View();
        }
    }
}
