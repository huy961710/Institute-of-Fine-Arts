using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
//step 1
using Microsoft.EntityFrameworkCore;
namespace Student_Design_Posting.Models
{
    //step 2 implement Dbcontext
    public class StudentDB : DbContext
    {
        public StudentDB(DbContextOptions options) : base(options) { }

        public DbSet<Design> Design { get; set; }
        public DbSet<Student> Student { get; set; }
        public DbSet<Competition> Competition { get; set; }
        public DbSet<Staff> Staff { get; set; }
        public DbSet<Posting> Postings { get; set; }
    }
}
