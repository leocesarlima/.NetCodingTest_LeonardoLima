using Icatu.EmployeeManagerWebAPI.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Icatu.EmployeeManagerUnitTest.Mock
{
    public class DepartmentDTOMock
    {
        public static readonly DepartmentDTO Department = new DepartmentDTO
        {
            Id = 1,
            Name = "TesteName_1",
            Employees = new List<EmployeeDTO>
            {
                new EmployeeDTO
                {
                    Name = "TesteName_1"
                }
            }
        };

        public static readonly DepartmentDTO DepartmentNoName = new DepartmentDTO
        {
            Id = 1,
            Name = "",
            Employees = new List<EmployeeDTO>
            {
                new EmployeeDTO
                {
                    Name = "TesteName_1"
                }
            }
        };

        public static readonly DepartmentDTO DepartmentWithNameGreaterThanAllowed = new DepartmentDTO
        {
            Id = 1,
            Name = new string('\t', 101),
            Employees = new List<EmployeeDTO>
            {
                new EmployeeDTO
                {
                    Name = "TesteName_1"
                }
            }
        };
    }
}
