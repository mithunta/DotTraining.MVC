using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace DotTraining.MVC.Controllers
{
    [Route("[controller]")]
    public class AuthorsController : Controller
    {
        
        public AuthorsController(ILogger<AuthorsController> logger)
        {

        }
        public IActionResult Index()
        {
            return View();
        }

        [Route("author-book-page")]
        public IActionResult Index1(int id, string authorname)
        {
            if(id < 10)
            {
                return View();
            }
            return RedirectToAction("Index");
        }
        [Route("authors/author-book-page1/{id}")]
        public IActionResult TestMethod(int id,string authorname)
        {
            return View("index");
        }
    }
}