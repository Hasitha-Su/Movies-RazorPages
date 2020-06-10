using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Movies_RazorPages.Models;

namespace Movies_RazorPages.Data
{
    public class Movies_RazorPagesContext : DbContext
    {
        public Movies_RazorPagesContext (DbContextOptions<Movies_RazorPagesContext> options)
            : base(options)
        {
        }

        public DbSet<Movies_RazorPages.Models.Movie> Movie { get; set; }
    }
}
