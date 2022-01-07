using Core5Practise.Models;
using Microsoft.AspNetCore.Mvc;

namespace Core5Practise.Controllers
{
    public class DataTr : Controller
    {
        // GET
        public IActionResult Index()
        {
            var tuple = (new Student(), new Teacher());
            return View(tuple);
        }
        [HttpPost]
        public IActionResult GetData([Bind(Prefix="item1")] Student student,[Bind(Prefix="item2")]Teacher teacher)
        {
            
            
            
            
            return RedirectToAction("Index");
        }
    }
}