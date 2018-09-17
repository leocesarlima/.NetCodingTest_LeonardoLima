using System.Linq;
using NUnit.Framework;
using Icatu.EmployeeManagerBusiness.Operation;
using Icatu.EmployeeManagerIntegratedTest.Mocks;

namespace Icatu.EmployeeManagerIntegratedTest.OperationTests
{
    public class OperationBaseTest
    {
        private OperationEmployee _operationEmployee;
        public OperationEmployee OperationEmployee
        {
            get => _operationEmployee ?? (_operationEmployee = new OperationEmployee());
            set => _operationEmployee = value;
        }

        private OperationDepartment _operationDepartment;
        public OperationDepartment OperationDepartment
        {
            get => _operationDepartment ?? (_operationDepartment = new OperationDepartment());
            set => _operationDepartment = value;
        }

        [SetUp]
        public void Initialize()
        {
            OperationDepartment.Save(DepartmentMock.Department);
            EmployeeMock.AddDepartment(EmployeeMock.Employee);
            OperationEmployee.Save(EmployeeMock.Employee);
        }

        [OneTimeTearDown]
        public void Cleanup()
        {
            var employees = OperationEmployee.GetAll().ToList();

            foreach (var employee in employees)
                OperationEmployee.Delete(employee.Id);

            var departments = OperationDepartment.GetAll().ToList();

            foreach (var department in departments)
                OperationDepartment.Delete(department.Id);
        }
    }
}
