using EmployeeManagement.Models.CustomValidators;
using System;
using System.ComponentModel.DataAnnotations;

namespace EmployeeManagement.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }

        [EmailAddress]
        [EmailDomainValidators(AllowedDomain = "rajusoft.com", ErrorMessage = "only rajusoft.com domain is allowed.")]
        public string Email { get; set; }

        public DateTime DateOfBirth { get; set; }

        public Gender Gender { get; set; }

        public string PhotoPath { get; set; }

        public Department Department { get; set; }

        public int? DepartmentId { get; set; }

    }


}
