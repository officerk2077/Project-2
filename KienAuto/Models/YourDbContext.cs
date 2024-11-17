using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace KienAuto.Models
{
    public class YourDbContext : DbContext
    {
        public YourDbContext() : base("YourDbContext") { }

        public DbSet<User> Users { get; set; }
    }
}