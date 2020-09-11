﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
//step 1
using Microsoft.EntityFrameworkCore;
namespace Manage_design.Models
{
    public class DesignDB : DbContext
    {
        public DesignDB(DbContextOptions options) : base(options) { }
        public DbSet<Design> Design { get; set; }
        public DbSet<Student> Student { get; set; }
    }
}
