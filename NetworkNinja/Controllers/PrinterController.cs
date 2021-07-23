using Microsoft.AspNetCore.Mvc;

namespace NetworkNinja.Controllers
{
    public class PrinterController : Controller
    {
        public IActionResult Usability()
        {
            return View();
        }

        public IActionResult Parts()
        {
            return View();
        }

        public IActionResult Guidelines()
        {
            return View();
        }

        public IActionResult Moves()
        {
            return View();
        }
    }
}
