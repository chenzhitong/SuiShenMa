using Microsoft.AspNetCore.Mvc;

namespace SuiShenMa.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Check(string name)
        {
            ViewBag.Name = name;
            return View();
        }
    }
}
