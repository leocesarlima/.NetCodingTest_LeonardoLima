using FluentValidation;

namespace Icatu.EmployeeManagerWebAPI.Model.Validator
{
    public class EmployeeDTOValidator : AbstractValidator<EmployeeDTO>
    {
        public EmployeeDTOValidator()
        {
            RuleFor(x => x.Name)
                .NotEmpty().WithMessage("The field Name is required.")
                .MaximumLength(32).WithMessage("The field Name maximum size is 100.");

            RuleFor(x => x.Mail)
                .NotEmpty().WithMessage("The field Mail is required.")
                .MaximumLength(32).WithMessage("The field Mail maximum size is 50.");
        }
    }
}
