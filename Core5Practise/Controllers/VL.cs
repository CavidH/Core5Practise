using System.Linq;
using Core5Practise.Models;
using Microsoft.AspNetCore.Mvc;

namespace Core5Practise.Controllers.Vl {
    public class VL : Controller
    {
        // GET
        public IActionResult CreateProduct()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateProduct(Product product)
        {
            if (!ModelState.IsValid)
            {
                // foreach (var erorr in ModelState.Values.FirstOrDefault().Errors)
                // {
                //     ModelState.AddModelError("",erorr.ErrorMessage);
                // }
                // var msg = ModelState.ToList();

                return View(product);
            }
          
            return Content("");
        }
        
    }
}