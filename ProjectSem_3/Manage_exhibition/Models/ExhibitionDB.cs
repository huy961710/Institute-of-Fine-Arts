using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Manage_exhibition.Models
{
    public class ExhibitionDB: DbContext
    {
        public ExhibitionDB(DbContextOptions options) : base(options) { }
        public DbSet<Exhibition> Exhibitions { get; set; }
        public DbSet<Staff> Staffs { get; set; }
    }
}
