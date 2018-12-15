using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using LIST.Models;

namespace LIST.Data
{
    public class DocentContext : DbContext
    {
        public DocentContext(DbContextOptions<DocentContext> options) : base(options)
        {

        }

        public DbSet<Authentication> Logindata { get; set; }
        public DbSet<Teacher> Docenten { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Authentication>().ToTable("Authentication");
            modelBuilder.Entity<Teacher>().ToTable("Teacher");
        }
    }
}
