using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Manage_design.Models;
//step 1
using Microsoft.EntityFrameworkCore;
namespace Manage_design.Models
{
    //step 2 implement Dbcontext
    public class DesignDB : DbContext
    {
        public DesignDB(DbContextOptions options) : base(options) { }

        public DbSet<Design> Design { get; set; }
    }
}
