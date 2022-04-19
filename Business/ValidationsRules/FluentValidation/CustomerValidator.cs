using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationsRules.FluentValidation
{
    public class CustomerValidator : AbstractValidator<Customer>
    {
        public CustomerValidator()
        {

        }
    }

}
