using FluentValidation.App.Models;

namespace FluentValidation.App.FluentValidator
{
    public class AddressValidator:AbstractValidator<Address>
    {
        public AddressValidator()
        {
            RuleFor(x=>x.Content).NotEmpty();
            RuleFor(x=>x.Province).NotEmpty();
            RuleFor(x => x.PostCode).NotEmpty().MaximumLength(5);
               
        }
    }
}
