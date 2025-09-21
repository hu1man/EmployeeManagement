using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.src.EmployeeApp.UI.Models
{
    public class EmployeeDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = "";
        public string Email { get; set; } = "";
        public decimal DepartmentId { get; set; } 
        public string DepartmentName { get; set; } = "";
        public string JoiningDate { get; set; }  // formatted yyyy-MM-dd string for display
        public decimal Salary { get; set; } // monthly pay
    }
}
