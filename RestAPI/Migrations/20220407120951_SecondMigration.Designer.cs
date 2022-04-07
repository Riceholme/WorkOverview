﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RestAPI.Model;

namespace RestAPI.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20220407120951_SecondMigration")]
    partial class SecondMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.23")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Models.Employee", b =>
                {
                    b.Property<int>("EmployeeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmpName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EmployeeId");

                    b.ToTable("Employees");

                    b.HasData(
                        new
                        {
                            EmployeeId = 1,
                            Email = "Ris@Sut.com",
                            EmpName = "Erik R"
                        },
                        new
                        {
                            EmployeeId = 2,
                            Email = "Nor@Sut.com",
                            EmpName = "Erik N"
                        },
                        new
                        {
                            EmployeeId = 3,
                            Email = "Ros@Sut.com",
                            EmpName = "Lukas R"
                        },
                        new
                        {
                            EmployeeId = 4,
                            Email = "Gun@Sut.com",
                            EmpName = "Viktor G"
                        });
                });

            modelBuilder.Entity("Models.Project", b =>
                {
                    b.Property<int>("ProjectId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ProjectName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ProjectId");

                    b.ToTable("Projects");

                    b.HasData(
                        new
                        {
                            ProjectId = 1,
                            ProjectName = "User Reg"
                        },
                        new
                        {
                            ProjectId = 2,
                            ProjectName = "Shopping Cart"
                        },
                        new
                        {
                            ProjectId = 3,
                            ProjectName = "Transaction"
                        });
                });

            modelBuilder.Entity("Models.TimeReport", b =>
                {
                    b.Property<int>("TimeReportId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<int>("HoursWorked")
                        .HasColumnType("int");

                    b.Property<int>("ProjectId")
                        .HasColumnType("int");

                    b.Property<int>("WeekNumber")
                        .HasColumnType("int");

                    b.HasKey("TimeReportId");

                    b.HasIndex("EmployeeId");

                    b.HasIndex("ProjectId");

                    b.ToTable("TimeReports");

                    b.HasData(
                        new
                        {
                            TimeReportId = 1,
                            EmployeeId = 1,
                            HoursWorked = 20,
                            ProjectId = 1,
                            WeekNumber = 1
                        },
                        new
                        {
                            TimeReportId = 2,
                            EmployeeId = 2,
                            HoursWorked = 20,
                            ProjectId = 1,
                            WeekNumber = 1
                        },
                        new
                        {
                            TimeReportId = 3,
                            EmployeeId = 3,
                            HoursWorked = 35,
                            ProjectId = 2,
                            WeekNumber = 1
                        },
                        new
                        {
                            TimeReportId = 4,
                            EmployeeId = 4,
                            HoursWorked = 35,
                            ProjectId = 3,
                            WeekNumber = 1
                        },
                        new
                        {
                            TimeReportId = 5,
                            EmployeeId = 1,
                            HoursWorked = 20,
                            ProjectId = 2,
                            WeekNumber = 2
                        },
                        new
                        {
                            TimeReportId = 6,
                            EmployeeId = 2,
                            HoursWorked = 20,
                            ProjectId = 2,
                            WeekNumber = 2
                        },
                        new
                        {
                            TimeReportId = 7,
                            EmployeeId = 3,
                            HoursWorked = 20,
                            ProjectId = 3,
                            WeekNumber = 2
                        },
                        new
                        {
                            TimeReportId = 8,
                            EmployeeId = 4,
                            HoursWorked = 20,
                            ProjectId = 3,
                            WeekNumber = 2
                        },
                        new
                        {
                            TimeReportId = 9,
                            EmployeeId = 1,
                            HoursWorked = 25,
                            ProjectId = 2,
                            WeekNumber = 3
                        },
                        new
                        {
                            TimeReportId = 10,
                            EmployeeId = 2,
                            HoursWorked = 25,
                            ProjectId = 3,
                            WeekNumber = 3
                        },
                        new
                        {
                            TimeReportId = 11,
                            EmployeeId = 3,
                            HoursWorked = 30,
                            ProjectId = 2,
                            WeekNumber = 3
                        },
                        new
                        {
                            TimeReportId = 12,
                            EmployeeId = 4,
                            HoursWorked = 30,
                            ProjectId = 3,
                            WeekNumber = 3
                        });
                });

            modelBuilder.Entity("Models.TimeReport", b =>
                {
                    b.HasOne("Models.Employee", "Employee")
                        .WithMany()
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Models.Project", "Project")
                        .WithMany()
                        .HasForeignKey("ProjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
