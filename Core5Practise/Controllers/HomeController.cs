using Core5Practise.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Core5Practise.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var s = new Student { Name = "Cavid", SurName = "Haciyev" };
            var t = new Teacher { Name = "Cavid", SurName = "Haciyev" };


            var PersonTuple = (s, t);
            return View(PersonTuple);
        }

        public IActionResult Create()
        {
            var product = new Product
            {
                name = "SDDS",
                quantity =87    
            };
            return View(product);
        }
        
        // [HttpPost]
        // public IActionResult Create(Product product)
        // {
        //     return View();
        // }
        //
        [HttpPost]
        public IActionResult Create(IFormCollection datas)
        {
            var a = datas["name"].ToString();
            var b = datas["quantity"].ToString();
            
            return View();
        }
    }
}
