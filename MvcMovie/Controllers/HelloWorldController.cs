using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        // GET: /HelloWord/Index/
        public IActionResult Index()
        {
            return View();
        }

        // GET: /HelloWorld/
        public IActionResult Welcome(string name, string sport)
        {
            ViewData["Name"] = name;
            ViewData["Sport"] = sport;
            return View();
        }
    }
}

