using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
//step 1
using Microsoft.EntityFrameworkCore;
namespace Manage_design.Models
{
    public class DesignDB : DbContext
    {
        public DesignDB(DbContextOptions options) : base(options) { }
        public DbSet<Design> Design { get; set; }
        public DbSet<Student> Student { get; set; }
        public DbSet<Posting> Posting { get; set; }
        public DbSet<Display> Display { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Display>()
                .HasKey(d => new { d.DesignId, d.ExhibitionID });
        }
    }
}
