using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Web;
using WebApplication3.Models;

namespace WebApplication3.Data
{
        public class ApplicationDbContext : DbContext
        {

            public ApplicationDbContext() { }
            public ApplicationDbContext(DbCompiledModel model) : base("DefaultConnection")
            {
            }

            public DbSet<City> Cities { get; set; }
            public DbSet<Province> Provinces { get; set; }
        }
}