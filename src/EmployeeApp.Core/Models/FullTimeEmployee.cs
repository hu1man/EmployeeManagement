using EmployeeApp.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.src.EmployeeApp.Core.Models
{
    public class FullTimeEmployee : Employee
    {
        public override decimal CalculateMonthlyPay() => Salary;
    }
}
