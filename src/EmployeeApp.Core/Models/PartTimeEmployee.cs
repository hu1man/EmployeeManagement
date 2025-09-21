using EmployeeApp.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.src.EmployeeApp.Core.Models
{
    public class PartTimeEmployee : Employee
    {
        public decimal HourlyRate { get; set; }
        public int HoursPerWeek { get; set; }

        public override decimal CalculateMonthlyPay() =>
            HourlyRate * HoursPerWeek * 4; // rough monthly
    }
}
