using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Manage_posting.Models
{
    public class PostingDB: DbContext
    {
        public PostingDB(DbContextOptions options) : base(options) { }

        public DbSet<Posting> Posting { get; set; }
        public DbSet<Design> Design { get; set; }
        public DbSet<Competition> Competition { get; set; }
        public DbSet<Staff> Staff { get; set; }
    }
}
