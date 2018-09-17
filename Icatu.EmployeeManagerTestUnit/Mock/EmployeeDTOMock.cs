using Icatu.EmployeeManagerWebAPI.Model;

namespace Icatu.EmployeeManagerUnitTest.Mock
{
    public class EmployeeDTOMock
    {
        public static readonly EmployeeDTO Employee = new EmployeeDTO
        {
            Id = 1,
            Name = "TesteName_1",
            Mail = "TesteMail_1",
            IdDepartament = 1
        };

        public static readonly EmployeeDTO EmployeeNoName = new EmployeeDTO
        {
            Id = 1,
            Name = "",
            Mail = "TesteMail_2",
            IdDepartament = 1
        };
    }
}
