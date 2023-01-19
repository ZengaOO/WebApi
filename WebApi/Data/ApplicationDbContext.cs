using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using WebApi.Models;

namespace WebApi.Data
{
    public class ApplicationDbContext  : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
         : base(options)
        { 
        }
        public DbSet<City> Cities { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<State> States { get; set; }

    }
}
