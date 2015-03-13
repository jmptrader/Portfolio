using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Portfolio.Models;

namespace Portfolio.Entities
{
    public class EFDbContext : DbContext
    {
        public DbSet<Project> Project { get; set; }
    }
}