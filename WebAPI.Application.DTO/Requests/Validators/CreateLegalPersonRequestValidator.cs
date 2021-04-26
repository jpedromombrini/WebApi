using FluentValidation;

namespace WebAPI.Application.DTO.Requests.Validators
{
    public class CreateLegalPersonRequestValidator : AbstractValidator<CreateLegalPersonRequest>
    {
        public CreateLegalPersonRequestValidator() 
        {
            RuleFor(x => x.Cnpj).NotNull().NotEmpty().Length(14);
            RuleFor(x => x.CompanyName).NotNull().NotEmpty().MaximumLength(200);
            RuleFor(x => x.Subscription).NotNull().NotEmpty().MaximumLength(30);
            RuleFor(x => x.Fantasy).NotNull().NotEmpty().MaximumLength(50);
        }
    }
}