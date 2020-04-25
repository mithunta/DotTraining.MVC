using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotTraining.MVC.Models
{
    
    public class Author
    {
        public int AuthorId { get; set; }
        public string AuthorName { get; set; }
        public int AuthorAge { get; set; }
    }
    
    public class Book
    {
        public int BookId { get; set; }
        public string BookName { get; set; }
    }
}
