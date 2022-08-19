using BullyBookWeb.Data;
using Microsoft.AspNetCore.Mvc;
using BullyBookWeb.Models;

namespace BullyBookWeb.Controllers
{
    public class AirPlaneTicketsController : Controller
    {
        private readonly ApplicationDbContext _db;

        public AirPlaneTicketsController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<Tickets> objTicketsList = _db.Tickets;
            return View(objTicketsList);
        }

        // Get 
        public IActionResult Create()
        {
            return View();
        }

        // Post 
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Tickets obj)
        {
            if (ModelState.IsValid)
            {
                _db.Tickets.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);
        }
    }
}
