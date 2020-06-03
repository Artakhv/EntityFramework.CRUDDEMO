using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntityFramework.CRUDDEMO
{
    internal class EmplayeeContext : DbContext
 
    {
        private readonly string connectionString;

        public EmplayeeContext(string connectionString)
        {
            this.connectionString = connectionString;
        }
        public DbSet<Employee> Employees { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString);
        }
    }
}
