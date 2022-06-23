using Microsoft.AspNetCore.Mvc;

namespace _22may.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
