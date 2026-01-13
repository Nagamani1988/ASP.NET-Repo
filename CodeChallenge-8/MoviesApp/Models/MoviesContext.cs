using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MoviesApp.Models
{
    public class MoviesContext : DbContext
    {
        public MoviesContext() : base("MoviesDB")
        {
        }
        public DbSet<Movie> Movies { get; set; }
    }
}
