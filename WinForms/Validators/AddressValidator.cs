using FluentValidation;
using Models;

namespace WinForms.Validators
{
    internal class AddressValidator : AbstractValidator<AddressModel>
    {
        public AddressValidator()
        {
            // Firstname
            RuleFor(a => a.Firstname)
                .Cascade(CascadeMode.Stop)
                .NotEmpty()
                .When(a => !string.IsNullOrWhiteSpace(a.Address1) ||
                           !string.IsNullOrWhiteSpace(a.City) ||
                           !string.IsNullOrWhiteSpace(a.Lastname))
                .WithMessage("Ingrese el nombre en el domicilio");
            // Lastname
            RuleFor(a => a.Lastname)
                .Cascade(CascadeMode.Stop)
                .NotEmpty()
                .When(a => !string.IsNullOrWhiteSpace(a.Address1) ||
                           !string.IsNullOrWhiteSpace(a.City) ||
                           !string.IsNullOrWhiteSpace(a.Firstname))
                .WithMessage("Ingrese el apellido en el domicilio");
            // Address #1
            RuleFor(a => a.Address1)
                .Cascade(CascadeMode.Stop)
                .NotEmpty()
                .When(a => !string.IsNullOrWhiteSpace(a.Firstname) ||
                           !string.IsNullOrWhiteSpace(a.Lastname) ||
                           !string.IsNullOrWhiteSpace(a.City))
                .WithMessage("Ingrese el domicilio #1");
            // City
            RuleFor(a => a.City)
                .Cascade(CascadeMode.Stop)
                .NotEmpty()
                .When(a => !string.IsNullOrWhiteSpace(a.Address1) ||
                           !string.IsNullOrWhiteSpace(a.Lastname) ||
                           !string.IsNullOrWhiteSpace(a.Firstname))
                .WithMessage("Ingrese la ciudad del domicilio");
            // Country
            RuleFor(a => a.Country)
                .Cascade(CascadeMode.Stop)
                .Must(c => c.ID != 0)
                .When(a => !string.IsNullOrWhiteSpace(a.Address1) ||
                           !string.IsNullOrWhiteSpace(a.Firstname) ||
                           !string.IsNullOrWhiteSpace(a.Lastname) ||
                           !string.IsNullOrWhiteSpace(a.City) ||
                           a.Zone.ID != 0)
                .WithMessage("Ingrese el país del domicilio");
            // Zone
            RuleFor(a => a.Zone)
                .Cascade(CascadeMode.Stop)
                .Must(z => z.ID != 0)
                .When(a => !string.IsNullOrWhiteSpace(a.Address1) ||
                           !string.IsNullOrWhiteSpace(a.Lastname) ||
                           !string.IsNullOrWhiteSpace(a.Firstname) ||
                           !string.IsNullOrWhiteSpace(a.City))
                .WithMessage("Ingrese la región del domicilio");
        }
    }
}
