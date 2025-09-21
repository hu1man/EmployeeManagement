-- Create Database (only run once)
CREATE DATABASE EmployeeDB;
GO

USE EmployeeDB;
GO

-- Drop existing tables if they exist (for clean re-run)
IF OBJECT_ID('dbo.Employees', 'U') IS NOT NULL DROP TABLE dbo.Employees;
IF OBJECT_ID('dbo.Department', 'U') IS NOT NULL DROP TABLE dbo.Department;
GO

-- Department Table
CREATE TABLE [dbo].[Department] (
    [Id]   INT            IDENTITY (1, 1) NOT NULL,
    [Name] NVARCHAR (100) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

-- Employees Table
CREATE TABLE [dbo].[Employees] (
    [Id]           INT            IDENTITY (1, 1) NOT NULL,
    [Name]         NVARCHAR (200) NOT NULL,
    [Email]        NVARCHAR (200) NOT NULL,
    [DepartmentId] INT            NULL,
    [JoiningDate]  DATE           NOT NULL,
    [Salary]       REAL           NOT NULL,
    [EmployeeType] NVARCHAR (20)  NOT NULL,
    [HourlyRate]   REAL           NULL,
    [HoursPerWeek] INT            NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    FOREIGN KEY ([DepartmentId]) REFERENCES [dbo].[Department] ([Id])
);

-- Seed Departments
INSERT INTO [dbo].[Department] (Name)
VALUES ('HR'), ('Finance'), ('IT'), ('Sales');

-- Seed Employees
INSERT INTO [dbo].[Employees] 
    (Name, Email, DepartmentId, JoiningDate, Salary, EmployeeType, HourlyRate, HoursPerWeek)
VALUES
    ('Alice Johnson','alice@example.com', 1, '2024-01-10', 5000.00,'FullTime', NULL, NULL),
    ('Bob Part','bob@example.com', 2, '2024-03-15', 0.00,'PartTime', 20.00, 20),
    ('Charlie Smith','charlie@example.com', 3, '2024-05-20', 6500.00,'FullTime', NULL, NULL),
    ('Dana Worker','dana@example.com', 4, '2024-07-01', 0.00,'PartTime', 25.00, 15);
