using FluentValidation;

namespace WinForms.Validators
{
    internal class SettingsValidator : AbstractValidator<Properties.Settings>
    {
        public SettingsValidator()
        {
            RuleFor(p => p.email)
               .Cascade(CascadeMode.Stop)
               .NotEmpty().WithMessage("El correo remitente no ha sido establecido");
            RuleFor(p => p.email_pwd)
                .Cascade(CascadeMode.Stop)
                .NotEmpty().WithMessage("La contraseña de correo no ha sido establecida");
            RuleFor(p => p.host)
               .Cascade(CascadeMode.Stop)
               .NotEmpty().WithMessage("El host del servicio de correo no está establecido");
            RuleFor(p => p.port)
               .Cascade(CascadeMode.Stop)
               .NotEmpty().WithMessage("El puerto del servicio de correo no está establecido");
        }
    }
}
