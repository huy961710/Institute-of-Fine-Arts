using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Manage_award.Models
{
    public class AwardDB: DbContext
    {
        public AwardDB(DbContextOptions options) : base(options) { }

        public DbSet<Award> Awards { get; set; }
        public DbSet<Competition> Competitions { get; set; }
        public DbSet<Staff> Staffs { get; set; }
        public DbSet<Posting> Postings { get; set; }
    }
}
