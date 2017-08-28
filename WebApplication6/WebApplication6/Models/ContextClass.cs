using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace WebApplication6.Models
{
    public class ContextClass : DbContext
    {
        public ContextClass()
            : base("NewCustomerDbContext")
        {
        }
        public DbSet<NewCustomer> NewCustomers { get; set; }
    }

}