using BookServiceWEBAPI.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace BookServiceWEBAPI.Database
{
    public class MyContext : DbContext //inheriting dbcontext
    {
        private IConfiguration config;

        public MyContext()
        {
        }

        public MyContext(IConfiguration cfg)
        {
            config = cfg;
        }

        public DbSet<Book>? Books { get; set; }

        public DbSet<User> Users { get; set; }

        //configure connection string
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(config["ConnectionString"]);
            base.OnConfiguring(optionsBuilder);
        }
    }
}