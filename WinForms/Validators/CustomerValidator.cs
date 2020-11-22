using FluentValidation;
using Models;
using System.Text.RegularExpressions;

namespace WinForms.Validators
{
    internal class CustomerValidator : AbstractValidator<CustomerModel>
    {
        public CustomerValidator()
        {
            RuleFor(c => c.CustomerGroup)
                .Cascade(CascadeMode.Stop)
                .Must(cg => cg.ID > 0).WithMessage("Seleccione el grupo del cliente");
            RuleFor(c => c.Firstname)
                .Cascade(CascadeMode.Stop)
                .NotEmpty().WithMessage("Ingrese el nombre del cliente")
                .Must(IsValidName).WithMessage("Ingrese un nombre de cliente válido");
            RuleFor(c => c.Lastname)
                .Cascade(CascadeMode.Stop)
                .NotEmpty().WithMessage("Ingrese el apellido del cliente")
                .Must(IsValidName).WithMessage("Ingrese un apellido de cliente válido");
            RuleFor(c => c.Email)
                .Cascade(CascadeMode.Stop)
                .NotEmpty().WithMessage("Ingrese el correo del cliente")
                .EmailAddress().WithMessage("El correo del cliente no es válido");
            RuleFor(c => c.Telephone)
                .Cascade(CascadeMode.Stop)
                .NotEmpty().WithMessage("Ingrese el número telefónico del cliente")
                .Must(IsValidTelephone).WithMessage("El número telefónico no es válido");
            RuleFor(c => c.Address).SetValidator(new AddressValidator());
        }

        private bool IsValidTelephone(string number) => Regex.Match(number, @"\(?\d{3}\)?-? *\d{3}-? *-?\d{4}").Success;

        private bool IsValidName(string name) => Regex.IsMatch(name, @"^[\w+\s]*$", RegexOptions.IgnoreCase);
    }
}
