using Microsoft.AspNetCore.Mvc;

namespace SimpleApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public FileResult Download()
        {
            return File(@"Files\001.Introduction.pdf", "application/pdf");
        }
    }
}
