using FluentValidation;

namespace Core5Practise.Models.Validators
{
    public class ProductValidator :AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(p => p.name)
                .NotNull()
                .WithMessage("name bosh ola bilmez")
                .NotEmpty()
                .WithMessage("name bosh ola bilmez");
            RuleFor(p => p.name)
                .MaximumLength(50)
                .WithMessage("50 simvoldan boyuk ad daxil edtmek olmaz");

            RuleFor(p => p.Email)
                .NotNull()
                .WithMessage("name bosh ola bilmez")
                .NotEmpty()
                .WithMessage("name bosh ola bilmez");
            RuleFor(p => p.Email)
                .EmailAddress()
                .WithMessage(" duzgun email adres daxil edin");
            
        }
    }
}