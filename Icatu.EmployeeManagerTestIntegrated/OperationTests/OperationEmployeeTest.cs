using System.Linq;
using NUnit.Framework;
using Icatu.EmployeeManagerDomain.Entities;
using Icatu.EmployeeManagerIntegratedTest.Mocks;

namespace Icatu.EmployeeManagerIntegratedTest.OperationTests
{
    [TestFixture]
    public class OperationEmployeeTest : OperationBaseTest
    {
        [Test, TestCaseSource(typeof(EmployeeMock), "Employee")]
        public void WhenSaveEmployeeShouldReturnSucess (Employee employee)
        {
            EmployeeMock.AddDepartment(employee);
            var sucess = OperationEmployee.Save(employee);
            Assert.IsTrue(sucess, "Error saving employee.");
        }

        [Test]
        public void WhenUpdateEmployeeShouldReturnSucess()
        {
            var sucess = OperationEmployee.Update(EmployeeMock.Employee);
            Assert.IsTrue(sucess, "Error updating employee.");
        }

        [Test]
        public void WhenGetAllShouldReturnEmployees()
        {
            var employees = OperationEmployee.GetAll();
            Assert.IsTrue(employees.Any(), "No employees found.");
        }

        [Test]
        public void WhenGetByIdShouldReturnEmployee()
        {
            var employee = OperationEmployee.GetById(EmployeeMock.Employee.Id);
            Assert.IsNotNull(employee, "Employee not found.");
        }

        [Test]
        public void WhenGetByFilterShouldReturnEmployees()
        {
            var employees = OperationEmployee.GetByFilter(EmployeeMock.Employee.Name);
            Assert.IsTrue(employees.Any(), "No employees found.");
        }

        [Test]
        public void WhenGetByIdDepartmentShouldReturnEmployees()
        {
            var employees = OperationEmployee.GetByIdDepartment(DepartmentMock.Department.Id);
            Assert.IsTrue(employees.Any(), "No employees found.");
        }

        [Test]
        public void WhenDeleteEmployeeShouldReturnSucess()
        {
            var sucesso = OperationEmployee.Delete(EmployeeMock.Employee.Id);
            Assert.IsTrue(sucesso, "Error deleting employee.");
        }
    }
}
