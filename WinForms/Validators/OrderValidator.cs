using FluentValidation;
using Models;

namespace WinForms.Validators
{
    internal class OrderValidator : AbstractValidator<OrderDataModel>
    {
        public OrderValidator()
        {
            // Customer
            RuleFor(o => o.Customer)
                .Cascade(CascadeMode.Stop)
                .SetValidator(new CustomerValidator());
            // Currency
            RuleFor(o => o.Currency.ID)
                .Cascade(CascadeMode.Stop)
                .NotEmpty().WithMessage("Seleccione el tipo de moneda");
            // Products
            RuleFor(o => o.Cart)
                .Cascade(CascadeMode.Stop)
                .NotEmpty()
                .WithMessage("No hay productos en el carrito");
            // Payment Method
            RuleFor(o => o.PaymentMethod.Code)
                .Cascade(CascadeMode.Stop)
                .NotEmpty().WithMessage("Seleccione el método de pago");
            // Payment address
            RuleFor(o => o.PaymentAddress)
                .Cascade(CascadeMode.Stop)
                .SetValidator(new AddressValidator())
                .WithMessage("Establezca los datos del domicilio de facturación");
            // Shipping Method
            RuleFor(o => o.ShippingMethod.Code)
                .Cascade(CascadeMode.Stop)
                .NotEmpty()
                .WithMessage("Seleccione el método de envío");
            // Shipping address
            RuleFor(o => o.ShippingAddress)
                .Cascade(CascadeMode.Stop)
                .SetValidator(new AddressValidator())
                .WithMessage("Establezca los datos del domicilio para el envío");
            // Order Status
            RuleFor(o => o.OrderStatus)
                .NotEmpty().WithMessage("No se ha establecido el estado de la venta");
        }

        private bool ValidateAddress(AddressModel addr)
            => string.IsNullOrWhiteSpace(addr.Firstname) ||
               string.IsNullOrWhiteSpace(addr.Lastname) ||
               string.IsNullOrWhiteSpace(addr.Address1) ||
               string.IsNullOrWhiteSpace(addr.City) ||
               addr.Country.ID == 0 || addr.Zone.ID == 0;
    }
}
