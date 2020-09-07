using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
//step 1
using Microsoft.EntityFrameworkCore;
namespace Manage_student.Models
{
    //step 2 implement Dbcontext
    public class StudentDB : DbContext
    {
        public StudentDB(DbContextOptions options) : base(options) { }

        public DbSet<Student> Student { get; set; }
    }
}
