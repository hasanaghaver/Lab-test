using _05._06.Data;
using Microsoft.AspNetCore.Mvc;
using System.Security.AccessControl;

namespace _05._06.Controllers
{
    public class HomeController: Controller
    {
        private readonly AppDbContext _context;
        public HomeController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View(_context);
        }
    }
}
