using FluentValidation;

namespace WebAPI.Application.DTO.Requests.Validators
{
    public class CreatePersonRequestValidator<T> : AbstractValidator<T> where T : CreatePersonRequest
    {
        public CreatePersonRequestValidator()
        {
            RuleFor(x => x.Address).SetValidator(new CreateAddressRequestValidator());
            RuleFor(x => x.Email).EmailAddress().WithMessage("Must be a valid email");
            RuleFor(x => x.Phone).NotNull().NotEmpty().Matches("[1-9]{2}[0-9]{10}").WithMessage("Phone must be [1-9]{2}[0-9]{10}");
            RuleFor(x => x.PersonType).NotNull().IsInEnum();

        }
    }
}