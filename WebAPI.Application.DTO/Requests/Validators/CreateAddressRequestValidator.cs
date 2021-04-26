using FluentValidation;

namespace WebAPI.Application.DTO.Requests.Validators
{
    public class CreateAddressRequestValidator : AbstractValidator<CreateAddressRequest>
    {
        public CreateAddressRequestValidator()
        {
            RuleFor(x => x.ZipCode).NotNull().NotEmpty();
            RuleFor(x => x.City).NotNull().NotEmpty();
            RuleFor(x => x.Neighborhood).NotNull().NotEmpty();
            RuleFor(x => x.PublicPlace).NotNull().NotEmpty();
            RuleFor(x => x.State).NotNull().NotEmpty();
        }
    }
}