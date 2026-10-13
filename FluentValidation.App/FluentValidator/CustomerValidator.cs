using FluentValidation.App.Models;

namespace FluentValidation.App.FluentValidator
{
    public class CustomerValidator : AbstractValidator<Customer>
    {
        public string NotEmptyMessage { get; } = "{PropertyName} alanı boş olamaz";

        public CustomerValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Name alanı boş olamaz");
            RuleFor(x => x.Mail).NotEmpty().WithMessage("e mail alanı boş olamaz").
                EmailAddress().WithMessage("e mail alanı doğru formatta değil");

            RuleFor(x => x.Age).NotEmpty().WithMessage("yaş alanı boş olamaz")
                .InclusiveBetween(18, 60).WithMessage("yaş alanı 18 ile 60 arasında olmalıdır");

            RuleFor(x => x.BirthDate).NotEmpty()
                .WithMessage("{PropertyName} alanı boş olamaz")
                .Must(x =>
                {
                    return DateTime.Now.AddYears(-18) >= x;
                }).WithMessage("Yaşını 18 yaşından büyük olmalıdır");

            RuleFor(x => x.Gender).IsInEnum().WithMessage("erkek için 1 bayan için 2 olmalı");
            RuleForEach(x => x.Address).SetValidator(new AddressValidator());
        }
    }
}
