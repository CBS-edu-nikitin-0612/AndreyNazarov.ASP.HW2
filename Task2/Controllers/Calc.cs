using Microsoft.AspNetCore.Mvc;

namespace Task2.Controllers
{
    public class CalcController : Controller
    {
        public IActionResult Add(int left, int right)
        {
            return View("Result", left + right);
        }
        public IActionResult Mul(int left, int right)
        {
            return View("Result", left * right);
        }
        public IActionResult Div(int left, int right)
        {
            return View("Result", left / right);
        }
        public IActionResult Sub(int left, int right)
        {
            return View("Result", left - right);
        }
    }
}
