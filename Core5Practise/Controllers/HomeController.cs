using System;
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
            public IActionResult Product()
            {
                var headers = Request.Headers;

                 return Content(" ");
            }
            // public IActionResult Product(string id,string a,string b)
            // {
            //     var values = Request.RouteValues;
            //     var headers = Request.Headers;
            //
            //      return Content(" ");
            // }
            // public IActionResult Product(QueryData queryData)
            // {
            //
            //    
            //     return Content(" ");
            // }
            // public IActionResult Product()
            // {
            //     var c=Request.QueryString; //request zamanı gələn query sting haqqında məlumat üçün
            //     var id = Request.Query["id"].ToString();
            //     var name = Request.Query["name"].ToString();
            //    
            //     return Content(" ");
            // }
        
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
        
        
        
        [HttpPost]
        public IActionResult ResJs(AjaxData ajaxData)
        {

            return Json(ajaxData);
        }
    }

    public class AjaxData
    {
        public string A { get; set; }
        public string B { get; set; }
        
    }

    //public class QueryData
    //{
    //    public int id { get; set; }
    //    public string Name { get; set; }
        
    //}
}
