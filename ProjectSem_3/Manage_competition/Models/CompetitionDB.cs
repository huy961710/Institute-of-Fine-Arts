using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Manage_competition.Models
{
    public class CompetitionDB: DbContext
    {
        public CompetitionDB(DbContextOptions options) : base(options) { }
        public DbSet<Competition> Competitions { get; set; }
        public DbSet<Staff> Staffs { get; set; }
    }
}
