using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Manage_address.Models
{
    public class AddressDB: DbContext
    {
        public AddressDB(DbContextOptions options) : base(options) { }
        public DbSet<Address> Address { get; set; }
    }
}
