using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using LIST.Models;

namespace LIST.Data
{
    public class LeerlingContext : DbContext
    {
        

        public LeerlingContext(DbContextOptions<LeerlingContext> options) : base(options)
        {
          
        }

        public DbSet<Authentication> Logindata { get; set; }
        public DbSet<Student> Leerlingen { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Authentication>().ToTable("Authentication");
            modelBuilder.Entity<Student>().ToTable("Student");
        }
    }
}
