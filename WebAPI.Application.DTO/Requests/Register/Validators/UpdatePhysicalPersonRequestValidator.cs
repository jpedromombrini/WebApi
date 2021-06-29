using FluentValidation;

namespace WebAPI.Application.DTO.Requests.Register.Validators
{
    public class UpdatePhysicalPersonRequestValidator : AbstractValidator<UpdatePhysicalPersonRequest>
    {
        public UpdatePhysicalPersonRequestValidator()
        {
            RuleFor(x => x.Address).SetValidator(new UpdateAddressRequestValidator());
            RuleFor(x => x.Email).EmailAddress().WithMessage("Must be a valid email");
            RuleFor(x => x.Phone).NotNull().NotEmpty().Matches("[1-9]{2}[0-9]{8}").WithMessage("Phone must be [1-9]{2}[0-9]{10}");
            RuleFor(x => x.PersonType).NotNull().IsInEnum();
            RuleFor(x => x.Cpf).NotNull().NotEmpty().Length(11);
            RuleFor(x => x.Name).NotNull().NotEmpty().MaximumLength(200);

        }

    }
}