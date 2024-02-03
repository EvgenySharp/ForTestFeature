using FluentValidation;

namespace Auth.BuisnessLayer
{
    public class LoginUserRequestDtoValidator : AbstractValidator<LoginUserRequestDto>
    {
        public LoginUserRequestDtoValidator()
        {
            RuleFor(user => user.Name)
                .Empty().MaximumLength(5);

            RuleFor(user => user.Password)
                .NotEmpty();
        }
    }
}
