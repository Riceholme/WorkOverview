using Microsoft.EntityFrameworkCore;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestAPI.Model
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<TimeReport> TimeReports { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Employee>().
                HasData(new Employee
                {
                    EmployeeId = 1,
                    EmpName = "Erik R",
                    Email = "Ris@Sut.com"
                });
            modelBuilder.Entity<Employee>().
                HasData(new Employee
                {
                    EmployeeId = 2,
                    EmpName = "Erik N",
                    Email = "Nor@Sut.com"
                });
            modelBuilder.Entity<Employee>().
                HasData(new Employee
                {
                    EmployeeId = 3,
                    EmpName = "Lukas R",
                    Email = "Ros@Sut.com"
                });
            modelBuilder.Entity<Employee>().
                HasData(new Employee
                {
                    EmployeeId = 4,
                    EmpName = "Viktor G",
                    Email = "Gun@Sut.com"
                });
            modelBuilder.Entity<Project>().
                HasData(new Project
                {
                    ProjectId = 1,
                    ProjectName = "User Reg"
                });
            modelBuilder.Entity<Project>().
                HasData(new Project
                {
                    ProjectId = 2,
                    ProjectName = "Shopping Cart"
                });
            modelBuilder.Entity<Project>().
                HasData(new Project
                {
                    ProjectId = 3,
                    ProjectName = "Transaction"
                });

            modelBuilder.Entity<TimeReport>().
                HasData(new TimeReport
                {
                    TimeReportId = 1,
                    WeekNumber = 1,
                    HoursWorked = 20,
                    EmployeeId = 1,
                    ProjectId = 1
                });
            modelBuilder.Entity<TimeReport>().
                HasData(new TimeReport
                {
                    TimeReportId = 2,
                    WeekNumber = 1,
                    HoursWorked = 20,
                    EmployeeId = 2,
                    ProjectId = 1
                });
            modelBuilder.Entity<TimeReport>().
                HasData(new TimeReport
                {
                    TimeReportId = 3,
                    WeekNumber = 1,
                    HoursWorked = 35,
                    EmployeeId = 3,
                    ProjectId = 2
                });
            modelBuilder.Entity<TimeReport>().
                HasData(new TimeReport
                {
                    TimeReportId = 4,
                    WeekNumber = 1,
                    HoursWorked = 35,
                    EmployeeId = 4,
                    ProjectId = 3
                });
            modelBuilder.Entity<TimeReport>().
                HasData(new TimeReport
                {
                    TimeReportId = 5,
                    WeekNumber = 2,
                    HoursWorked = 20,
                    EmployeeId = 1,
                    ProjectId = 2
                });
            modelBuilder.Entity<TimeReport>().
                HasData(new TimeReport
                {
                    TimeReportId = 6,
                    WeekNumber = 2,
                    HoursWorked = 20,
                    EmployeeId = 2,
                    ProjectId = 2
                });
            modelBuilder.Entity<TimeReport>().
                HasData(new TimeReport
                {
                    TimeReportId = 7,
                    WeekNumber = 2,
                    HoursWorked = 20,
                    EmployeeId = 3,
                    ProjectId = 3
                });
            modelBuilder.Entity<TimeReport>().
                HasData(new TimeReport
                {
                    TimeReportId = 8,
                    WeekNumber = 2,
                    HoursWorked = 20,
                    EmployeeId = 4,
                    ProjectId = 3
                });
            modelBuilder.Entity<TimeReport>().
                HasData(new TimeReport
                {
                    TimeReportId = 9,
                    WeekNumber = 3,
                    HoursWorked = 25,
                    EmployeeId = 1,
                    ProjectId = 2
                });
            modelBuilder.Entity<TimeReport>().
                HasData(new TimeReport
                {
                    TimeReportId = 10,
                    WeekNumber = 3,
                    HoursWorked = 25,
                    EmployeeId = 2,
                    ProjectId = 3
                });
            modelBuilder.Entity<TimeReport>().
                HasData(new TimeReport
                {
                    TimeReportId = 11,
                    WeekNumber = 3,
                    HoursWorked = 30,
                    EmployeeId = 3,
                    ProjectId = 2
                });
            modelBuilder.Entity<TimeReport>().
                HasData(new TimeReport
                {
                    TimeReportId = 12,
                    WeekNumber = 3,
                    HoursWorked = 30,
                    EmployeeId = 4,
                    ProjectId = 3
                });

        }

    }
}
