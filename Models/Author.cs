using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DotTraining.MVC.Models
{
    
    [Table("Author")]
    public class Author
    {
        [Required]
        
        public int AuthorId { get; set; }
        
        public string AuthorName { get; set; }
        [Column("Author_Age")]
        public int AuthorAge { get; set; }
    }
    
    public class Book
    {
        public int BookId { get; set; }
        public string BookName { get; set; }
        public decimal BookPrice { get; set; }
    }
}
