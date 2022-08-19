using BullyBookWeb.Data;
using BullyBookWeb.Models;
using Microsoft.AspNetCore.Mvc;

namespace BullyBookWeb.Controllers
{
    public class MemberController : Controller
    {
        private readonly ApplicationDbContext _db;

        public MemberController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<Member> objMemberList = _db.Members;
            return View(objMemberList);
        }
    }
}
