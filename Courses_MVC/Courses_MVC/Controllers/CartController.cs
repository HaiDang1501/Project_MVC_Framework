using Courses_MVC.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Web;

namespace Courses_MVC.Controllers
{
    public class CartController : Controller

    {
        private string CartSession = "CartSession";
        public IActionResult Index()
        {
            return View();            
        }
       
        
    }
}
