using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FramWorkExamples
{
    public class AppDbContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderLines> OrderLines { get; set; }
        
        
        public AppDbContext() { } //default constructor

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { 
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connStr = "server=localhost\\sqlexpress;" + //connection string
                            "database=SalesDb;" +
                            "trusted_connection=true;" +
                            "trustServerCertificate=true;";
            optionsBuilder.UseSqlServer(connStr);
        }
    }
}
