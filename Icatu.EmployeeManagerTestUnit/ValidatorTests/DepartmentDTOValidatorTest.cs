using NUnit.Framework;
using Icatu.EmployeeManagerWebAPI.Model.Validator;
using Icatu.EmployeeManagerUnitTest.Mock;

namespace Icatu.EmployeeManagerUnitTest.ValidatorTests
{
    [TestFixture]
    public class DepartmentDTOValidatorTest
    {
        private DepartmentDTOValidator _departmentDTOValidator;
        public DepartmentDTOValidator DepartmentDTOValidator
        {
            get => _departmentDTOValidator ?? (_departmentDTOValidator = new DepartmentDTOValidator());
            set => _departmentDTOValidator = value;
        }

        [Test]
        public void WhenValidateDepartmentShouldReturnSucess()
        {
            var resultado = DepartmentDTOValidator.Validate(DepartmentDTOMock.Department);
            Assert.IsTrue(resultado.IsValid, "Department not validated.");
        }

        [Test]
        public void WhenValidateDepartmentNoNameShouldReturnError()
        {
            var resultado = DepartmentDTOValidator.Validate(DepartmentDTOMock.DepartmentNoName);
            Assert.IsFalse(resultado.IsValid, "Department not validated.");
        }

        [Test]
        public void WhenValidateDepartmentWithNameGreaterThanAllowedShouldReturnError()
        {
            var resultado = DepartmentDTOValidator.Validate(DepartmentDTOMock.DepartmentWithNameGreaterThanAllowed);
            Assert.IsFalse(resultado.IsValid, "Department not validated.");
        }
    }
}
