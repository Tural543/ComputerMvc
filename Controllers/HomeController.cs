using ComputerStore.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace ComputerStore.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly AppDbContext dbContex;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
          dbContex = new AppDbContext();
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult Melumat()
        {
            return View();
        }

        public IActionResult GetComputers()
        {
            var data = dbContex.Computers
                .Include(x => x.Marka)
                .ToList();
            return View(data);
        }
    }
}
