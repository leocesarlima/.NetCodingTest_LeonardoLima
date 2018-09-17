using System.Linq;
using Mapster;
using NUnit.Framework;
using Icatu.EmployeeManagerWebAPI.Model;
using Icatu.EmployeeManagerDomain.Entities;
using Icatu.EmployeeManagerUnitTest.Mock;

namespace Icatu.EmployeeManagerUnitTest.MapperTests
{
    public class DepartmentMapperTest
    {
        [Test]
        public void WhenMappingDepartmentToDepartmentDTOShouldReturnPropertiesWithSameValue()
        {
            var departmentDTO = DepartmentMock.Department.Adapt<DepartmentDTO>();

            Assert.AreEqual(DepartmentMock.Department.Id, departmentDTO.Id);
            Assert.AreEqual(DepartmentMock.Department.Name, departmentDTO.Name);
            Assert.IsTrue(departmentDTO.Employees.Any());
        }

        [Test]
        public void WhenMappingDepartmentDTOToDepartmentShouldReturnPropertiesWithSameValue()
        {
            var department = DepartmentDTOMock.Department.Adapt<Department>();

            Assert.AreEqual(DepartmentDTOMock.Department.Id, department.Id);
            Assert.AreEqual(DepartmentDTOMock.Department.Name, department.Name);
            Assert.IsTrue(department.Employees.Any());

        }
    }
}
