using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Manage_customer.Models
{
    public class CustomerDB: DbContext
    {
        public CustomerDB(DbContextOptions options) : base(options) { }
        public DbSet<Customer> Customers { get; set; }
    }
}
