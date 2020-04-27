using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using DotTraining.MVC.Models;
using Microsoft.AspNetCore.Http;
using System.ComponentModel;

namespace DotTraining.MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ErrorViewModel _errorViewModel;
        public HomeController(ILogger<HomeController> logger, ErrorViewModel errorViewModel)
        {
            _logger = logger;
            _errorViewModel = errorViewModel;
        }

        [HttpGet]
        public IActionResult Index()
        {

            AuthorBookViewModel vm = new AuthorBookViewModel();

            Author author = new Author();
            author.AuthorName = "Mithun";
            author.AuthorId = 1;
            author.AuthorAge = 30;

            vm.Author = author;

            Book book = new Book();
            book.BookId = 1;
            book.BookName = "C#";
            vm.Book = book;


            return View(vm);
            
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(AuthorBookViewModel vm)
        {
            if (ModelState.IsValid)
            {
               
                ModelState.Clear();
                vm.Author.AuthorName = "Mithun - 1";
            }
            return View(vm);
        }

        public IActionResult Privacy()
        {
            return File(new byte[1024],"type/pdf");
        }
        public JsonResult ReturnJson()
        {
            return Json(new Author());
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
