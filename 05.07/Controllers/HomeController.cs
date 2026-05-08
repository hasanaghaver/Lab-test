using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using _05._07.Models;
using _05._07.Data;

namespace _05._07.Controllers;

public class HomeController : Controller
{
    private readonly AppDbContext _context;

    public HomeController(AppDbContext context)
    {
        _context = context;
    }

    public IActionResult Index()
    {
        var services = _context.Services.ToList();
        return View(services);
    }
    
}
