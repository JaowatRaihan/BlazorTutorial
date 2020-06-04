using EmployeeManagement.Models;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace EmployeeManagement.Web.Pages
{
    public class EmployeeListBase : ComponentBase
    {
        public IEnumerable<Employee> Employees { get; set; }

        protected override async Task OnInitializedAsync()
        {
            await Task.Run(LoadEmployees);
        }

        private void LoadEmployees()
        {
            Thread.Sleep(3000);
            Employee employee1 = new Employee
            {
                EmployeeId = 1,
                FirstName = "John",
                LastName = "Doe",
                Email = "john@employee.com",
                DateOfBirth = new DateTime(1980, 12, 5),
                DepartmentId = 1,
                Gender = Gender.Male,
                PhotoPath = "images/john.jpg"
            };
            Employee employee2 = new Employee
            {
                EmployeeId = 2,
                FirstName = "John",
                LastName = "Doe",
                Email = "john@employee.com",
                DateOfBirth = new DateTime(1980, 12, 5),
                DepartmentId = 1,
                Gender = Gender.Male,
                PhotoPath = "images/cris.jpg"
            };
            Employee employee3 = new Employee
            {
                EmployeeId = 3,
                FirstName = "John",
                LastName = "Doe",
                Email = "john@employee.com",
                DateOfBirth = new DateTime(1980, 12, 5),
                DepartmentId = 2,
                Gender = Gender.Male,
                PhotoPath = "images/merry.jpg"
            };
            Employee employee4 = new Employee
            {
                EmployeeId = 4,
                FirstName = "John",
                LastName = "Doe",
                Email = "john@employee.com",
                DateOfBirth = new DateTime(1980, 12, 5),
                DepartmentId = 2,
                Gender = Gender.Male,
                PhotoPath = "images/alex.jpg"
            };

            Employees = new List<Employee> { employee1, employee2, employee3, employee4 };
        }
    }

    
}
