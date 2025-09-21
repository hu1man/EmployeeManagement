using System;
using System.ComponentModel.DataAnnotations;
using EmployeeApp.Core.Models;
using EmployeeManagement.src.EmployeeApp.Core.Models;

namespace EmployeeApp.Core.Models
{
    public abstract class Employee
    {
        public int Id { get; set; }

        private string _name;
        public string Name
        {
            get => _name;
            set => _name = (value ?? "").Trim();
        }

        private string _email;
        public string Email
        {
            get => _email;
            set => _email = (value ?? "").Trim();
        }

        public int? DepartmentId { get; set; }
        public Department Department { get; set; }

        public DateTime JoiningDate { get; set; } = DateTime.Now;

        public decimal Salary { get; set; } // Use for full-time simple salary

        // Polymorphic behaviour
        public abstract decimal CalculateMonthlyPay();
    }
}