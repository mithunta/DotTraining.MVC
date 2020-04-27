using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotTraining.MVC.Models
{
    public class DotTrainingContext : DbContext
    {
        public DotTrainingContext(DbContextOptions<DotTrainingContext> options) : base(options)
        {

        }

        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }
    }
}
