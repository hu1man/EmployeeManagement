using EmployeeApp.Core.Models;
using EmployeeManagement.src.EmployeeApp.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.src.EmployeeApp.Core.Interfaces
{
    public interface IEmployeeRepository
    {
        Task<List<Employee>> GetAllAsync();
        Task<Employee> GetByIdAsync(int id);
        Task AddAsync(Employee e);
        Task UpdateAsync(Employee e);
        Task DeleteAsync(int id);
        Task<List<Employee>> SearchAsync(string term);
        Task<List<Department>> GetDepartmentsAsync();
        Task<Dictionary<string, decimal>> GetTotalSalaryByDepartmentAsync();
    }
}
