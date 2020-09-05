using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Manage_subject.Models
{
    public class SubjectDB: DbContext
    {
        public SubjectDB(DbContextOptions options) : base(options) { }
        public DbSet<Subject> Subjects { get; set; }
    }
}
