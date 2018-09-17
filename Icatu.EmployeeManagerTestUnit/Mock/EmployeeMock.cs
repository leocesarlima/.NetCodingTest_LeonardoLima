using Icatu.EmployeeManagerDomain.Entities;

namespace Icatu.EmployeeManagerUnitTest.Mock
{
    public class EmployeeMock
    {
        public static readonly Employee Employee = new Employee
        {
            Id = 1,
            Name = "TesteName_1",
            Mail = "TesteMail_1",
            IdDepartament = 1
        };
    }
}
