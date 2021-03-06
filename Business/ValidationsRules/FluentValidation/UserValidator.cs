using Core.Entities.Concrete;
using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class UserValidator : AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(user => user.FirstName).NotEmpty();
            RuleFor(user => user.LastName).NotEmpty();
            RuleFor(user => user.PasswordHash).NotEmpty();
            RuleFor(user => user.PasswordSalt).NotEmpty();
            RuleFor(p => p.Email).NotEmpty().EmailAddress();
        }
    }
}