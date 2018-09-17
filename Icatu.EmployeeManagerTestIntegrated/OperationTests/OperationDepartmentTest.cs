using System.Linq;
using NUnit.Framework;
using Icatu.EmployeeManagerDomain.Entities;
using Icatu.EmployeeManagerIntegratedTest.Mocks;

namespace Icatu.EmployeeManagerIntegratedTest.OperationTests
{
    [TestFixture]
    public class OperationDepartmentTest: OperationBaseTest
    {
        [Test, TestCaseSource(typeof(DepartmentMock), "Department")]
        public void WhenSaveDepartmentShouldReturnSuccess(Department department)
        {
            var sucess = OperationDepartment.Save(department);
            Assert.IsTrue(sucess, "Error saving Department.");
        }

        [Test]
        public void WhenUpdateDepartmentShouldReturnSuccess()
        {
            var sucess = OperationDepartment.Update(DepartmentMock.Department);
            Assert.IsTrue(sucess, "Error updating Department.");
        }

        [Test]
        public void WhenGetAllShouldReturnDepartments()
        {
            var departments = OperationDepartment.GetAll();
            Assert.IsTrue(departments.Any(), "No departments found.");
        }

        [Test]
        public void WhenGetByIdShouldReturnDepartment()
        {
            var department = OperationDepartment.GetById(DepartmentMock.Department.Id);
            Assert.IsNotNull(department, "Department not found.");
        }

        [Test]
        public void WhenGetByFilterShouldReturnDepartments()
        {
            var departments = OperationDepartment.GetByFilter(DepartmentMock.Department.Name);
            Assert.IsNotNull(departments.Any(), "No departments found.");
        }

        [Test]
        public void WhenDeleteDepartmentShouldReturnSucess()
        {
            var sucesso = OperationDepartment.Delete(DepartmentMock.Department.Id);
            Assert.IsTrue(sucesso, "Error deleting department.");
        }
    }
}
