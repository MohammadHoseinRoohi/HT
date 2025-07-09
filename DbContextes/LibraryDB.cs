using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Project1.Entities;

namespace Project1.DbContextes
{
    public class LibraryDB : DbContext
    {
        public DbSet<CEO> CEOs { get; set; }
        public DbSet<Cooperative> Cooperatives { get; set; }
        public DbSet<Driver> Drivers { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Passenger> Passengers { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlite(@"Data source=DBFiles\Librarydb.sqlite");
        }
    }
}