using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
namespace WebApplication8.Models
{
    public class DataContext : DbContext
    {
        public DataContext() : base("conn") { }
        public DbSet<Worker> Employees { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<State> States { get; set; }
    }
}