using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Manage_administrator.Models
{
    public class AdministratorDB: DbContext
    {
        public AdministratorDB(DbContextOptions options) : base(options) { }
        public DbSet<Administrator> Administrators { get; set; }
    }
}
