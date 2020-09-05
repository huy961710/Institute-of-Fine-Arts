using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Manage_Staff.Models
{
    public class StaffDB: DbContext
    {
        public StaffDB(DbContextOptions options) : base(options) { }
        public DbSet<Staff> Staff { get; set; }
    }
}
