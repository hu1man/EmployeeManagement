using System;
using System.Data.SqlClient;

namespace EmployeeManagement.src.EmployeeApp.Data
{
    public static class DbInitializer
    {
        public static void Initialize(string connString)
        {
            using (var conn = new SqlConnection(connString))
            {
                conn.Open();

                // --- create tables (SQL Server syntax) ---
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = @"
    IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Department')
    BEGIN
        CREATE TABLE Department (
            Id INT IDENTITY(1,1) PRIMARY KEY,
            Name NVARCHAR(100) NOT NULL
        )
    END";
                    cmd.ExecuteNonQuery();
                }

                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = @"
    IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Employees')
    BEGIN
        CREATE TABLE Employees (
            Id INT IDENTITY(1,1) PRIMARY KEY,
            Name NVARCHAR(200) NOT NULL,
            Email NVARCHAR(200) NOT NULL,
            DepartmentId INT,
            JoiningDate DATE NOT NULL,
            Salary DECIMAL(18,2) NOT NULL,
            EmployeeType NVARCHAR(20) NOT NULL,
            HourlyRate DECIMAL(18,2),
            HoursPerWeek INT,
            FOREIGN KEY (DepartmentId) REFERENCES Department(Id)
        )
    END";
                    cmd.ExecuteNonQuery();
                }

                // --- seed departments if empty ---
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "SELECT COUNT(*) FROM Department";
                    var result = cmd.ExecuteScalar();
                    long count = Convert.ToInt64(result ?? 0);
                    if (count == 0)
                    {
                        var insert = conn.CreateCommand();
                        insert.CommandText = @"
    INSERT INTO Department (Name) VALUES
    (N'HR'), (N'Finance'), (N'IT'), (N'Sales')";
                        insert.ExecuteNonQuery();
                    }
                }

                // --- seed employees if empty ---
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "SELECT COUNT(*) FROM Employees";
                    var result = cmd.ExecuteScalar();
                    long count = Convert.ToInt64(result ?? 0);
                    if (count == 0)
                    {
                        var insert = conn.CreateCommand();
                        insert.CommandText = @"
    INSERT INTO Employees (Name, Email, DepartmentId, JoiningDate, Salary, EmployeeType, HourlyRate, HoursPerWeek)
    VALUES 
    (N'Alice Johnson','alice@example.com',1,'2024-01-10',5000,'FullTime',NULL,NULL),
    (N'Bob Part','bob@example.com',2,'2024-03-15',0,'PartTime',20,20)";
                        insert.ExecuteNonQuery();
                    }
                }
            }
        }
    }
}
