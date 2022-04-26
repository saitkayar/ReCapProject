using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationsRules.FluentValidation
{
    public class ColorValidator : AbstractValidator<Color>
    {
        public ColorValidator()
        {
            RuleFor(p => p.ColorName).NotEmpty();
            RuleFor(p => p.ColorName).MinimumLength(2);
        }
    }

}
