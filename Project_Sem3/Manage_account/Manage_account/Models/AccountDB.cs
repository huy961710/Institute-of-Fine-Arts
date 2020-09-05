using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Manage_account.Models
{
    public class AccountDB: DbContext
    {
        public AccountDB(DbContextOptions options) : base(options) { }
        public DbSet<Account> Accounts { get; set; }
    }
}
