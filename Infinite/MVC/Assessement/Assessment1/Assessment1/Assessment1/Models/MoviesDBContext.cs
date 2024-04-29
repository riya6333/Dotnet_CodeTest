﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Assessment1.Models
{
    public class MoviesDbContext : DbContext
    {
        public MoviesDbContext() : base("name=MoviesDBConnectionString")
        {
        }

        public DbSet<Movies> Movies { get; set; }
    }
}