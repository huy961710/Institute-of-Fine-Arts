using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Manage_manager.Models
{
    public class ManagerDB: DbContext
    {
        public ManagerDB(DbContextOptions options) : base(options) { }
        public DbSet<Manager> Managers { get; set; }
    }
}
