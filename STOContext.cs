using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.IO;
using lab5.Models;

namespace lab5.Data
{
    public class STOContext : DbContext
    {
        public DbSet<Car> Cars { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Owner> Owners { get; set; }
        public DbSet<Worker> Workers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var builder = new ConfigurationBuilder();
            builder.SetBasePath(Directory.GetCurrentDirectory());
            builder.AddJsonFile("appsettings.json");
            var config = builder.Build();
            string connectionString = config.GetConnectionString("DefaultConnection");

            var options = optionsBuilder
                .UseSqlServer(connectionString)
                .Options;
        }
    }
}
