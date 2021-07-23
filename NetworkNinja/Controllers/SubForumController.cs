using Microsoft.AspNetCore.Mvc;
using NetworkNinja.Data;
using NetworkNinja.Models;
using System.Collections.Generic;

namespace NetworkNinja.Controllers
{
    public class SubForumController : Controller
    {
        private readonly ApplicationDbContext _db;

        public SubForumController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Hardware()
        {
            IEnumerable<HardwareModel> hardware = _db.Hardware;

            return View(hardware);
        }

        public IActionResult Software()
        {
            IEnumerable<SoftwareModel> software = _db.Software;

            return View(software);
        }

        public IActionResult Printers()
        {
            IEnumerable<PrinterModel> printer = _db.Printer;

            return View(printer);
        }

        public IActionResult Phones()
        {
            IEnumerable<PhoneModel> phone = _db.Phone;

            return View(phone);
        }

        public IActionResult Administration()
        {
            IEnumerable<AdministrationModel> admin = _db.Administration;

            return View(admin);
        }
    }
}
