using DomainLayer.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Data
{
    public class ApplicationDbContext : DbContext{
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options) { }
        protected override void OnModelCreating(ModelBuilder builder){
            base.OnModelCreating(builder);
        }
        public DbSet<Order> Orders { get; set; }

        public DbSet<Product> Products { get; set; }


    }
    public class ApplicationDbContextFactory : IDesignTimeDbContextFactory<ApplicationDbContext>
    {
        public ApplicationDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=WidgetandCo;Integrated Security=True");

            return new ApplicationDbContext(optionsBuilder.Options);
        }
    }
}
