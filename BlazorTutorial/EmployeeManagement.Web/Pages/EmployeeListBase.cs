using EmployeeManagement.Models;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Web.Pages
{
    public class EmployeeListBase : ComponentBase
    {
        public IEnumerable<Employee> Employees { get; set; }

        protected override  async Task OnInitializedAsync()
        {
            await Task.Run(LoadEmployees);
          
        }

        private void LoadEmployees()
        {
            System.Threading.Thread.Sleep(3000);

            Employee e1 = new Employee
            {
                EmployeeId = 1,
                FirstName = "Boy",
                LastName = "Satterfitt",
                Email = "Eberhard@gamil.com",
                DateOfBirth = new DateTime(1980, 02, 02),
                Gender = Gender.Male,
                 DepartmentId=1,
                 PhotoPath = "images/Boy.jpg"
            };

            Employee e2 = new Employee
            {
                EmployeeId = 2,
                FirstName = "Lindsy",
                LastName = "James",
                Email = "Wyllcock@gamil.com",
                DateOfBirth = new DateTime(1981, 01, 05),
                Gender = Gender.Female,
                DepartmentId = 2,
                PhotoPath = "images/Lindsy.jpg"
            };

            Employee e3 = new Employee
            {
                EmployeeId = 3,
                FirstName = "Ryann",
                LastName = "Harris",
                Email = "Simkovich@gamil.com",
                DateOfBirth = new DateTime(1981, 09, 12),
                Gender = Gender.Female,
                DepartmentId = 3,
                PhotoPath = "images/Ryann.jpg"
            };

            Employee e4 = new Employee
            {
                EmployeeId = 4,
                FirstName = "Ruy",
                LastName = "Mandry",
                Email = "Mandry@gamil.com",
                DateOfBirth = new DateTime(1975, 09, 23),
                Gender = Gender.Male,
                DepartmentId = 4,
                PhotoPath = "images/Ruy.jpg"
            };

            Employee e5 = new Employee
            {
                EmployeeId = 5,
                FirstName = "Marcel",
                LastName = "Mandry",
                Email = "Marcel@gamil.com",
                DateOfBirth = new DateTime(1975, 10, 22),
                Gender = Gender.Male,
                DepartmentId = 5,
                PhotoPath = "images/Marcel.jpg"
            };

            Employees = new List<Employee> { e1, e2, e3, e4, e5 };


        }
    }
}
