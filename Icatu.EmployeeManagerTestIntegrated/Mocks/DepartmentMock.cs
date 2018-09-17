using System.Collections.Generic;
using Icatu.EmployeeManagerDomain.Entities;

namespace Icatu.EmployeeManagerIntegratedTest.Mocks
{
    public class DepartmentMock
    {
        public static readonly Department Department = new Department
        {
            Name = "Department_Name1"
        };

        static readonly IEnumerable<Department> Departments = new List<Department>
        {
            new Department
            {
                Name = "Department_Name2"
            },
            new Department
            {
                Name = "Department_Name3"
            },
            new Department
            {
                Name = "Department_Name4"
            }
        };
    }
}
