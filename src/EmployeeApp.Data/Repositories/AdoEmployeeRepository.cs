using EmployeeApp.Core.Models;
using EmployeeManagement.src.EmployeeApp.Core.Interfaces;
using EmployeeManagement.src.EmployeeApp.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace EmployeeManagement.src.EmployeeApp.Data.Repositories
{
    public class AdoEmployeeRepository : IEmployeeRepository
    {
        private readonly string _connString;
        public AdoEmployeeRepository(string connString) => _connString = connString;

        public async Task AddAsync(Employee e)
        {
            using (var con = new SqlConnection(_connString))
            {
                await con.OpenAsync();

                var cmd = con.CreateCommand();
                cmd.CommandText = @"
INSERT INTO Employees (Name, Email, DepartmentId, JoiningDate, Salary, EmployeeType, HourlyRate, HoursPerWeek)
VALUES (@name, @em, @dep, @join, @sal, @type, @hourly, @hours)";
                cmd.Parameters.AddWithValue("@name", e.Name);
                cmd.Parameters.AddWithValue("@em", e.Email);
                cmd.Parameters.AddWithValue("@dep", (object)e.DepartmentId ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@join", e.JoiningDate.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@sal", e.Salary);
                cmd.Parameters.AddWithValue("@type", e is PartTimeEmployee ? "PartTime" : "FullTime");
                if (e is PartTimeEmployee p)
                {
                    cmd.Parameters.AddWithValue("@hourly", p.HourlyRate);
                    cmd.Parameters.AddWithValue("@hours", p.HoursPerWeek);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@hourly", DBNull.Value);
                    cmd.Parameters.AddWithValue("@hours", DBNull.Value);
                }
                await cmd.ExecuteNonQueryAsync();
            }
        }

        public async Task UpdateAsync(Employee e)
        {
            using (var con = new SqlConnection(_connString))
            {
                await con.OpenAsync();
                var cmd = con.CreateCommand();
                cmd.CommandText = @"
UPDATE Employees SET 
    Name=@name, Email=@em, DepartmentId=@dep, JoiningDate=@join, Salary=@sal, EmployeeType=@type, HourlyRate=@hourly, HoursPerWeek=@hours
WHERE Id=@id";
                cmd.Parameters.AddWithValue("@id", e.Id);
                cmd.Parameters.AddWithValue("@name", e.Name);
                cmd.Parameters.AddWithValue("@em", e.Email);
                cmd.Parameters.AddWithValue("@dep", (object)e.DepartmentId ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@join", e.JoiningDate.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@sal", e.Salary);
                cmd.Parameters.AddWithValue("@type", e is PartTimeEmployee ? "PartTime" : "FullTime");
                if (e is PartTimeEmployee p)
                {
                    cmd.Parameters.AddWithValue("@hourly", p.HourlyRate);
                    cmd.Parameters.AddWithValue("@hours", p.HoursPerWeek);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@hourly", DBNull.Value);
                    cmd.Parameters.AddWithValue("@hours", DBNull.Value);
                }
                await cmd.ExecuteNonQueryAsync();
            }
        }

        public async Task DeleteAsync(int id)
        {
            using (var con = new SqlConnection(_connString))
            {
                await con.OpenAsync();
                var cmd = con.CreateCommand();
                cmd.CommandText = "DELETE FROM Employees WHERE Id=@id";
                cmd.Parameters.AddWithValue("@id", id);
                await cmd.ExecuteNonQueryAsync();
            }
        }

        public async Task<Employee> GetByIdAsync(int id)
        {
            using (var con = new SqlConnection(_connString))
            {
                await con.OpenAsync();
                var cmd = con.CreateCommand();
                cmd.CommandText = @"SELECT e.*, d.Id as DeptId, d.Name as DeptName 
                                    FROM Employees e LEFT JOIN Department d ON e.DepartmentId = d.Id
                                    WHERE e.Id=@id";
                cmd.Parameters.AddWithValue("@id", id);

                var reader = await cmd.ExecuteReaderAsync();
                if (await reader.ReadAsync())
                    return MapEmployee(reader);
                return null;
            }
        }

        public async Task<List<Employee>> GetAllAsync()
        {
            var list = new List<Employee>();

            using (var con = new SqlConnection(_connString))
            {
                await con.OpenAsync();
                var cmd = con.CreateCommand();
                cmd.CommandText = @"
            SELECT e.Id, e.Name, e.Email, e.DepartmentId,
                   d.Id AS DeptId, d.Name AS DeptName,
                   e.JoiningDate, e.Salary, e.EmployeeType,
                   e.HourlyRate, e.HoursPerWeek
            FROM Employees e
            LEFT JOIN Department d ON e.DepartmentId = d.Id";

                var reader = await cmd.ExecuteReaderAsync();
                while (await reader.ReadAsync())
                {
                    list.Add(MapEmployee(reader));
                }
            }

            return list;
        }


        public async Task<List<Employee>> SearchAsync(string term)
        {
            var employees = new List<Employee>();

            using (var conn = new SqlConnection(_connString))
            {
                await conn.OpenAsync();

                var query = @"
            SELECT e.Id, e.Name, e.Email, e.DepartmentId,
                   d.Id AS DeptId, d.Name AS DeptName,
                   e.JoiningDate, e.Salary, e.EmployeeType,
                   e.HourlyRate, e.HoursPerWeek
            FROM Employees e
            LEFT JOIN Department d ON e.DepartmentId = d.Id
            WHERE LOWER(e.Name) LIKE @term 
               OR LOWER(e.Email) LIKE @term 
               OR LOWER(d.Name) LIKE @term;";

                using (var cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@term", "%" + term.ToLower() + "%");

                    using (var reader = await cmd.ExecuteReaderAsync())
                    {
                        while (await reader.ReadAsync())
                        {
                            employees.Add(MapEmployee(reader));
                        }
                    }
                }
            }

            return employees;
        }




        public async Task<List<Department>> GetDepartmentsAsync()
        {
            var list = new List<Department>();
            using (var con = new SqlConnection(_connString))
            {
                await con.OpenAsync();
                var cmd = con.CreateCommand();
                cmd.CommandText = "SELECT * FROM Department ORDER BY Name";
                var reader = await cmd.ExecuteReaderAsync();
                while (await reader.ReadAsync())
                {
                    list.Add(new Department
                    {
                        Id = reader.GetInt32(0),
                        Name = reader.GetString(1)
                    });
                }
            }
            return list;
        }

        public async Task<Dictionary<string, decimal>> GetTotalSalaryByDepartmentAsync()
        {
            var dict = new Dictionary<string, decimal>();
            using (var con = new SqlConnection(_connString))
            {
                await con.OpenAsync();
                var cmd = con.CreateCommand();
                cmd.CommandText = @"SELECT ISNULL(d.Name,'Unassigned') as Dept, SUM(e.Salary) 
                                    FROM Employees e LEFT JOIN Department d ON e.DepartmentId = d.Id
                                    GROUP BY d.Name";
                var reader = await cmd.ExecuteReaderAsync();
                while (await reader.ReadAsync())
                {
                    string deptName = reader.GetString(0);
                    object salaryObj = reader.GetValue(1);
                    decimal totalSalary = 0;
                    if (salaryObj != DBNull.Value)
                    {
                        try
                        {
                            totalSalary = Convert.ToDecimal(salaryObj);
                        }
                        catch
                        {
                            totalSalary = 0; // fallback if conversion fails
                        }
                    }
                    dict[deptName] = totalSalary;
                }
            }
            return dict;
        }

        private Employee MapEmployee(SqlDataReader reader)
        {
            string type = reader.GetString(reader.GetOrdinal("EmployeeType"));

            Employee e;
            if (type == "PartTime")
            {
                e = new PartTimeEmployee
                {
                    HourlyRate = reader.IsDBNull(reader.GetOrdinal("HourlyRate"))
    ? 0 : (decimal)reader.GetFloat(reader.GetOrdinal("HourlyRate")),
                    HoursPerWeek = reader.IsDBNull(reader.GetOrdinal("HoursPerWeek")) ? 0 : reader.GetInt32(reader.GetOrdinal("HoursPerWeek"))
                };
            }
            else
            {
                e = new FullTimeEmployee();
            }

            e.Id = reader.GetInt32(reader.GetOrdinal("Id"));
            e.Name = reader.GetString(reader.GetOrdinal("Name"));
            e.Email = reader.GetString(reader.GetOrdinal("Email"));
            e.DepartmentId = reader.IsDBNull(reader.GetOrdinal("DepartmentId"))
                ? (int?)null : reader.GetInt32(reader.GetOrdinal("DepartmentId"));
            e.JoiningDate = reader.GetDateTime(reader.GetOrdinal("JoiningDate"));
            e.Salary = (decimal)reader.GetFloat(reader.GetOrdinal("Salary"));            //e.EmployeeType = type;

            if (!reader.IsDBNull(reader.GetOrdinal("DeptId")))
            {
                e.Department = new Department
                {
                    Id = reader.GetInt32(reader.GetOrdinal("DeptId")),
                    Name = reader.GetString(reader.GetOrdinal("DeptName"))
                };
            }

            return e;
        }

    }
}