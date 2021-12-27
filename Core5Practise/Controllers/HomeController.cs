using Core5Practise.Models;
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
    }
}
