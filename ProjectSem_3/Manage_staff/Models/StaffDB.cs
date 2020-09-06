using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Manage_staff.Models
{
    public class StaffDB: DbContext
    {
        public StaffDB(DbContextOptions options) : base(options) { }
        public DbSet<Staff> Staff { get; set; }
        public DbSet<Competition> Competition { get; set; }
        public DbSet<Award> Award { get; set; }
        public DbSet<Remark> Remark { get; set; }
        public DbSet<Posting> Posting { get; set; }
        public DbSet<Exhibition> Exhibition { get; set; }
    }
}
