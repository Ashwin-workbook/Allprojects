using FluentValidation;

namespace FluentValidation8
{
    public class UserDtoValidator:AbstractValidator<UserDto>
    {
        public UserDtoValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Name is required").MinimumLength(3);
            RuleFor(x => x.Age).InclusiveBetween(18, 60).WithMessage("Age must be between 18 and 60");
        }
    }
}
