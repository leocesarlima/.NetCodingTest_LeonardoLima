using Mapster;
using NUnit.Framework;
using Icatu.EmployeeManagerWebAPI.Model;
using Icatu.EmployeeManagerDomain.Entities;
using Icatu.EmployeeManagerUnitTest.Mock;

namespace Icatu.EmployeeManagerUnitTest.MapperTests
{
    [TestFixture]
    public class EmployeeMapperTest
    {
        [Test]
        public void WhenMappingEmployeeToEmployeeDTOShouldReturnPropertiesWithSameValue()
        {
            var employeeDTO = EmployeeMock.Employee.Adapt<EmployeeDTO>();

            Assert.AreEqual(EmployeeMock.Employee.Id, employeeDTO.Id);
            Assert.AreEqual(EmployeeMock.Employee.Name, employeeDTO.Name);
            Assert.AreEqual(EmployeeMock.Employee.Mail, employeeDTO.Mail);
            Assert.AreEqual(EmployeeMock.Employee.IdDepartament, employeeDTO.IdDepartament);
        }

        [Test]
        public void WhenMappingEmployeeDTOToEmployeeShouldReturnPropertiesWithSameValue()
        {
            var employee = EmployeeDTOMock.Employee.Adapt<Employee>();

            Assert.AreEqual(EmployeeDTOMock.Employee.Id, employee.Id);
            Assert.AreEqual(EmployeeDTOMock.Employee.Name, employee.Name);
            Assert.AreEqual(EmployeeDTOMock.Employee.Mail, employee.Mail);
            Assert.AreEqual(EmployeeDTOMock.Employee.IdDepartament, employee.IdDepartament);
        }
    }
}
