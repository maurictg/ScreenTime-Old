using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LIST.Models;
using Microsoft.EntityFrameworkCore;

namespace LIST.Data
{
    public class NewsContext : DbContext
    {
        public NewsContext(DbContextOptions<NewsContext> options) : base(options)
        {

        }

        public DbSet<News> Nieuws { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<News>().ToTable("News");
        }
    }
}
