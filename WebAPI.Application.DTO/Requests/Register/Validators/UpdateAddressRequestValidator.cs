using FluentValidation;

namespace WebAPI.Application.DTO.Requests.Register.Validators
{
    public class UpdateAddressRequestValidator : AbstractValidator<UpdateAddressRequest>
    {
        public UpdateAddressRequestValidator()
        {
            RuleFor(x => x.ZipCode).NotNull().NotEmpty();
            RuleFor(x => x.City).NotNull().NotEmpty();
            RuleFor(x => x.Neighborhood).NotNull().NotEmpty();
            RuleFor(x => x.PublicPlace).NotNull().NotEmpty();
            RuleFor(x => x.State).NotNull().NotEmpty();
        }
    }
}