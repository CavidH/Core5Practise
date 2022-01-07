using Microsoft.AspNetCore.Mvc;

namespace Core5Practise.Controllers
{
    public class DataTr : Controller
    {
        // GET
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult GetData()
        {
            
            
            
            return RedirectToAction("Index");
        }
    }
}