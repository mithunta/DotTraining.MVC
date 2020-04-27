using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DotTraining.MVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace DotTraining.MVC.Controllers
{
    //[Route("[controller]")]
    public class AuthorsController : Controller
    {

        private readonly DotTrainingContext _context;
        public AuthorsController(ILogger<AuthorsController> logger, DotTrainingContext context)
        {
            _context = context;
        }
        //CRUD
        //List all the authors that are in the database
        //R- Retrieve
        public IActionResult Index()
        {

            List <Author> authors = _context.Authors.ToList();

            return View(authors);
        }



        // Add New Authors
        //C- Create a new record
        [HttpGet]
        public IActionResult Add()
        {

            return View();
        }

        public IActionResult Add(Author author)
        {
            _context.Authors.Add(author);
            _context.SaveChanges();


            return RedirectToAction("Index");
        }

        //U - Update
        public IActionResult Edit(int id)
        {
            Author author = _context.Authors.Where(x => x.AuthorId == id).FirstOrDefault();

            return View(author);
        }

        [HttpPost]
        public IActionResult Edit(int id, Author author)
        {
            //Author _author = _context.Authors.Where(x => x.AuthorId == id).FirstOrDefault();
            //_author = author;
            _context.Update(author);
            _context.SaveChanges();


            return RedirectToAction("Index");
        }


        public IActionResult Delete(int id)
        {
            var author = _context.Authors.Where(x => x.AuthorId == id).FirstOrDefault();

            _context.Remove(author);
            _context.SaveChanges();

            return RedirectToAction("Index");
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