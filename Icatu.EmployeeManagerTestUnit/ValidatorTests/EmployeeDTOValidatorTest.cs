using NUnit.Framework;
using Icatu.EmployeeManagerUnitTest.Mock;
using Icatu.EmployeeManagerWebAPI.Model.Validator;

namespace Icatu.EmployeeManagerUnitTest.ValidatorTests
{
    [TestFixture]
    public class EmployeeDTOValidatorTest
    {
        private EmployeeDTOValidator _employeeDTOValidator;
        public EmployeeDTOValidator EmployeeDTOValidator
        {
            get => _employeeDTOValidator ?? (_employeeDTOValidator = new EmployeeDTOValidator());
            set => _employeeDTOValidator = value;
        }

        [Test]
        public void WhenValidateEmployeeShouldReturnSucess()
        {
            var result = EmployeeDTOValidator.Validate(EmployeeDTOMock.Employee);
            Assert.IsTrue(result.IsValid, "Employee not validated.");
        }

        [Test]
        public void WhenValidateEmployeeNoNameShouldReturnError()
        {
            var result = EmployeeDTOValidator.Validate(EmployeeDTOMock.EmployeeNoName);
            Assert.IsFalse(result.IsValid, "Employee not validated.");
        }
    }
}
