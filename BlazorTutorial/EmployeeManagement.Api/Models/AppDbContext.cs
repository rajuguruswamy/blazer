using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeeManagement.Models;
using Microsoft.EntityFrameworkCore;

namespace EmployeeManagement.Api.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //modelBuilder.Entity<Department>().HasData(new Department() { DepartmentId = 1, DepartmentName = "IT" });
            //modelBuilder.Entity<Department>().HasData(new Department() { DepartmentId = 2, DepartmentName = "HR" });
            //modelBuilder.Entity<Department>().HasData(new Department() { DepartmentId = 3, DepartmentName = "Payroll" });
            //modelBuilder.Entity<Department>().HasData(new Department() { DepartmentId = 4, DepartmentName = "Admin" });

            //modelBuilder.Entity<Employee>().HasData(
            //                                            new Employee
            //                                            {
            //                                                EmployeeId = 1,
            //                                                FirstName = "Boy",
            //                                                LastName = "Satterfitt",
            //                                                Email = "Eberhard@gamil.com",
            //                                                DateOfBirth = new DateTime(1980, 02, 02),
            //                                                Gender = Gender.Male,
            //                                                Department =  new Department() { DepartmentId = 1 },
            //                                                PhotoPath = "images/Boy.jpg"
            //                                            });

            //modelBuilder.Entity<Employee>().HasData(
            //                                       new Employee
            //                                       {
            //                                           EmployeeId = 2,
            //                                           FirstName = "Lindsy",
            //                                           LastName = "James",
            //                                           Email = "Wyllcock@gamil.com",
            //                                           DateOfBirth = new DateTime(1981, 01, 05),
            //                                           Gender = Gender.Female,
            //                                           Department = new Department() { DepartmentId = 2 },
            //                                           PhotoPath = "images/Lindsy.jpg"
            //                                       });

            //modelBuilder.Entity<Employee>().HasData(
            //                                         new Employee
            //                                         {
            //                                             EmployeeId = 3,
            //                                             FirstName = "Ryann",
            //                                             LastName = "Harris",
            //                                             Email = "Simkovich@gamil.com",
            //                                             DateOfBirth = new DateTime(1981, 09, 12),
            //                                             Gender = Gender.Female,
            //                                             Department = new Department() { DepartmentId = 3 },
            //                                             PhotoPath = "images/Ryann.jpg"
            //                                         });

            //modelBuilder.Entity<Employee>().HasData(
            //                                        new Employee
            //                                        {
            //                                            EmployeeId = 4,
            //                                            FirstName = "Ruy",
            //                                            LastName = "Mandry",
            //                                            Email = "Mandry@gamil.com",
            //                                            DateOfBirth = new DateTime(1975, 09, 23),
            //                                            Gender = Gender.Male,
            //                                             Department = new Department() { DepartmentId = 4 },
            //                                            PhotoPath = "images/Ruy.jpg"
            //                                        });

            //modelBuilder.Entity<Employee>().HasData(
            //                                       new Employee
            //                                       {
            //                                           EmployeeId = 5,
            //                                           FirstName = "Marcel",
            //                                           LastName = "Mandry",
            //                                           Email = "Marcel@gamil.com",
            //                                           DateOfBirth = new DateTime(1975, 10, 22),
            //                                           Gender = Gender.Male,
            //                                           Department = new Department() { DepartmentId = 4 },
            //                                           PhotoPath = "images/Marcel.jpg"
            //                                       });


        }
        /*Rum collowing commands to run data migratuibn ot sql server
            Add-Migration InitialCreate
            Update-Database
         
         */
        
    }
}
