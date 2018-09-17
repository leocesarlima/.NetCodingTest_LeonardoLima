using FluentValidation;

namespace Icatu.EmployeeManagerWebAPI.Model.Validator
{
    public class DepartmentDTOValidator : AbstractValidator<DepartmentDTO>
    {
        public DepartmentDTOValidator()
        {
            RuleFor(x => x.Name)
                .NotEmpty().WithMessage("The field Name is required.")
                .MaximumLength(32).WithMessage("The field Name maximum size is 100.");
        }
    }
}
