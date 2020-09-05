using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Manage_class.Models
{
    public class ClassDB: DbContext
    {
        public ClassDB(DbContextOptions options) : base(options) { }
        public DbSet<Class> Classs { get; set; }
    }
}
