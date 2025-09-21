# Employee Management System

A Windows Forms application built with **C#**, **ADO.NET (SqlClient)**, and **SQL Server** to manage employees and departments.

---

## 🚀 How to Build and Run

1. Clone the repository:
   ```bash
   git clone https://github.com/hu1man/EmployeeManagement.git

Open the solution in Visual Studio

Double-click EmployeeManagement.sln

Or open Visual Studio → File → Open → Project/Solution…

Restore NuGet packages
Visual Studio will do this automatically when the solution loads.
If not, right-click the solution in Solution Explorer → Restore NuGet Packages.

Set the startup project

Right-click EmployeeApp.UI → Set as Startup Project

Configure the database connection

Open App.config in EmployeeApp.UI

SQL Quaries for table creation is Located at scripts\create_tables_sqlite.sql

Update the connection string with your SQL Server instance:

<connectionStrings>
    <add name="EmployeeDB" connectionString="Data Source=DESKTOP-RU25KP9;Initial Catalog=EmployeeDB;Persist Security Info=True;User ID=sa;Password=123;" providerName="MySql.Data.MySqlClient" />
  </connectionStrings>


Replace:

DESKTOP-RU25KP9 & Uer ID , Password with your server name  ID & password(check in SSMS).

sa and YourPassword with valid SQL Server login.

Setup the database

Open SQL Server Management Studio (SSMS)

Connect to your server

Open Scripts/EmployeeDB_Create.sql from the repo

Run it → this will create the database, tables, and seed sample data.

Build and run

Press F5 (or Ctrl+F5) in Visual Studio

The WinForms app will launch

You should see seeded employees in the grid
----------------------------------------------------------------------------------

🧑‍💻 Features

Add, edit, delete employees.

Search employees by name, email, or department.

View employees in a DataGridView.

Calculate monthly pay (polymorphism: different for FullTime vs PartTime).

View total salary by department.
----------------------------------------------------------------------------------

🏛️ How Object-Oriented Concepts Applied

Encapsulation:

Employee properties are exposed via classes with controlled access.

Inheritance:

Employee (base class)

FullTimeEmployee and PartTimeEmployee (derived classes).

Polymorphism:

CalculateMonthlyPay() is overridden differently in FullTimeEmployee and PartTimeEmployee.

Abstraction (Interfaces):

IEmployeeRepository defines repository operations, implemented by AdoEmployeeRepository.

Separation of Concerns:

Core → business models and interfaces

Data → ADO.NET repository

UI → WinForms presentation layer
----------------------------------------------------------------------------------

📝 Assumptions

Database: SQL Server Express or SQL Server Developer Edition is available locally.

EmployeeType: Only FullTime or PartTime are valid.

Salary: For FullTimeEmployee, Salary represents monthly pay.
For PartTimeEmployee, HourlyRate × HoursPerWeek × 4 is calculated.

Departments: Basic 4 seeded departments (HR, Finance, IT, Sales).
----------------------------------------------------------------------------------

📂 Project Structure
EmployeeManagement.sln
│
├── EmployeeApp.Core
│   ├── Models (Employee, FullTimeEmployee, PartTimeEmployee, Department)
│   └── Interfaces (IEmployeeRepository)
│
├── EmployeeApp.Data
│   └── Repositories (AdoEmployeeRepository.cs)
│
├── EmployeeApp.UI
│   ├── Forms (MainForm, EmployeeForm)
│   └── Program.cs
│
└── Scripts
    └── EmployeeDB_Create.sql
----------------------------------------------------------------------------------
