using Microsoft.AspNetCore.Mvc;

namespace Core5Practise.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
