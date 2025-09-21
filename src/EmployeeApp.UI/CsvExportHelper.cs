using System.Collections.Generic;
using System.IO;
using System.Text;
using EmployeeApp.Core.Models;

namespace EmployeeApp.UI
{
    public static class CsvExportHelper
    {
        public static void ExportEmployeesToCsv(IEnumerable<Employee> employees, string path)
        {
            var sb = new StringBuilder();
            sb.AppendLine("Id,Name,Email,Department,JoiningDate,MonthlyPay");
            foreach (var e in employees)
            {
                var dept = e.Department?.Name ?? "";
                var pay = e.CalculateMonthlyPay();
                sb.AppendLine($"{e.Id},\"{Escape(e.Name)}\",\"{Escape(e.Email)}\",\"{Escape(dept)}\",\"{e.JoiningDate:yyyy-MM-dd}\",{pay}");
            }
            File.WriteAllText(path, sb.ToString(), Encoding.UTF8);
        }

        private static string Escape(string s) => (s ?? "").Replace("\"", "\"\"");
    }
}
