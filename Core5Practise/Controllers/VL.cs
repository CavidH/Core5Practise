using Microsoft.AspNetCore.Mvc;

namespace Core5Practise.Controllers.Vl {
    public class VL : Controller
    {
        // GET
        public IActionResult Index()
        {
            return View();
        }
    }
}