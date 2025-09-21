using EmployeeApp.Core.Models;
using EmployeeManagement.src.EmployeeApp.Core.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.src.EmployeeApp.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> opts) : base(opts) { }

        protected override void OnModelCreating(ModelBuilder model)
        {
            // TPH inheritance mapping
            model.Entity<Employee>()
                .HasDiscriminator<string>("EmployeeType")
                .HasValue<FullTimeEmployee>("FullTime")
                .HasValue<PartTimeEmployee>("PartTime");

            model.Entity<Employee>().Property(e => e.Name).HasMaxLength(100).IsRequired();
            model.Entity<Department>().Property(d => d.Name).HasMaxLength(50).IsRequired();
        }
    }
}
