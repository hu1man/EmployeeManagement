using EmployeeManagement.src.EmployeeApp.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.src.EmployeeApp.Data
{
    public static class DataSeeder
    {
        public static void Seed(AppDbContext db)
        {
            db.Database.EnsureCreated();

            if (!db.Departments.Any())
            {
                db.Departments.AddRange(
                    new Department { Name = "HR" },
                    new Department { Name = "Finance" },
                    new Department { Name = "IT" },
                    new Department { Name = "Sales" }
                );
                db.SaveChanges();
            }

            if (!db.Employees.Any())
            {
                db.Employees.Add(new FullTimeEmployee
                {
                    Name = "Alice Johnson",
                    Email = "alice@example.com",
                    DepartmentId = db.Departments.First().Id,
                    JoiningDate = System.DateTime.Now.AddMonths(-12),
                    Salary = 5000
                });

                db.Employees.Add(new PartTimeEmployee
                {
                    Name = "Bob Part",
                    Email = "bob@example.com",
                    DepartmentId = db.Departments.First().Id,
                    JoiningDate = System.DateTime.Now.AddMonths(-3),
                    HourlyRate = 20,
                    HoursPerWeek = 20,
                    Salary = 0 // Salary optional for part-time in this model
                });

                db.SaveChanges();
            }
        }
    }
}
