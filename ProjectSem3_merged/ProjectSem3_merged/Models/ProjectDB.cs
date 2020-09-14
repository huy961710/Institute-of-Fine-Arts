using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ProjectSem3_merged.Models
{
    public class ProjectDB: DbContext
    {
        public ProjectDB(DbContextOptions options) : base(options) { }

        public DbSet<Competition> Competitions { get; set; }
        public DbSet<Staff> Staffs { get; set; }
        public DbSet<Posting> Postings { get; set; }
        public DbSet<Design> Designs { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Award> Awards { get; set; }
        public DbSet<Exhibition> Exhibitions { get; set; }
        public DbSet<Display> Display { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Display>()
                .HasKey(d => new { d.DesignID, d.ExhibitionID });
        }
    }
}
