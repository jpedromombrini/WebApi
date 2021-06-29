using FluentValidation;

namespace WebAPI.Application.DTO.Requests.Register.Validators
{
    public class CreateLegalPersonRequestValidator : AbstractValidator<CreateLegalPersonRequest>
    {
        public CreateLegalPersonRequestValidator() 
        {
            RuleFor(x => x.Address).SetValidator(new CreateAddressRequestValidator());
            RuleFor(x => x.Email).EmailAddress().WithMessage("Must be a valid email");
            RuleFor(x => x.Phone).NotNull().NotEmpty().Matches("[1-9]{2}[0-9]{8}").WithMessage("Phone must be [1-9]{2}[0-9]{10}");
            RuleFor(x => x.PersonType).NotNull().IsInEnum();
            RuleFor(x => x.Cnpj).NotNull().NotEmpty().Length(14);
            RuleFor(x => x.CompanyName).NotNull().NotEmpty().MaximumLength(200);
            RuleFor(x => x.Subscription).NotNull().NotEmpty().MaximumLength(30);
            RuleFor(x => x.Fantasy).NotNull().NotEmpty().MaximumLength(50);
        }
    }
}