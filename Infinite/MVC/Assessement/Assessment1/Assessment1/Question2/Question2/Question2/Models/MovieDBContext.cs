using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Question2.Models
{
    public class MovieDBContext : DbContext
    {
        public MovieDBContext() : base("name=MoviesDBConnectionString")
        {
        }

        public DbSet<Movie> Movies { get; set; }
    }
}