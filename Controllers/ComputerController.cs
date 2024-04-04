using ComputerStore.Class;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.Elfie.Serialization;

namespace ComputerStore.Controllers
{
    public class ComputerController : Controller
    {
        AppDbContext context = new AppDbContext();
        public IActionResult Index()
        {
            var data = context.Computers.ToList();
            return View(data);
        }
        [HttpGet]
        public IActionResult Add()
        {

            return View();
        }
        public IActionResult Add(Computer computer)
        {

            context.Computers.Add(computer);
            context.SaveChanges();
            return RedirectToAction("Index");
            
        }
        
    }
}
