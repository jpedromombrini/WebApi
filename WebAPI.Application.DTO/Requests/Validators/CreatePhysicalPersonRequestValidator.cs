using FluentValidation;

namespace WebAPI.Application.DTO.Requests.Validators
{
    public class CreatePhysicalPersonRequestValidator : AbstractValidator<CreatePhysicalPersonRequest>
    {
        public CreatePhysicalPersonRequestValidator()
        {
            RuleFor(x => x.Cpf).NotNull().NotEmpty().Length(11);
            RuleFor(x => x.Name).NotNull().NotEmpty().MaximumLength(200);
        }
    }
}