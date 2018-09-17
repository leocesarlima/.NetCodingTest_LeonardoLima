using System.Collections.Generic;
using Icatu.EmployeeManagerDomain.Entities;

namespace Icatu.EmployeeManagerUnitTest.Mock
{
    public class DepartmentMock
    {
        public static readonly Department Department = new Department
        {
            Id = 1,
            Name = "TesteName_1",
            Employees = new List<Employee>
            {
                new Employee
                {
                    Name = "TesteName_1"
                }
            }
        };
    }
}
