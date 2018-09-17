using System.Collections.Generic;
using Icatu.EmployeeManagerDomain.Entities;

namespace Icatu.EmployeeManagerIntegratedTest.Mocks
{
    public class EmployeeMock
    {
        public static readonly Employee Employee = new Employee
        {
            Name = "EmployeeName_1",
            Mail = "EmployeeMail_1"
        };

        static readonly IEnumerable<Employee> Employees = new List<Employee>
        {
            new Employee
            {
                Name = "EmployeeName_2",
                Mail = "EmployeeMail_2"
            },
            new Employee
            {
                Name = "EmployeeName_3",
                Mail = "EmployeeMail_3"
            },
            new Employee
            {
                Name = "EmployeeName_4",
                Mail = "EmployeeMail_4"
            }
        };

        public static void AddDepartment(Employee employee)
        {
            employee.Id = DepartmentMock.Department.Id;
        }
    }
}
