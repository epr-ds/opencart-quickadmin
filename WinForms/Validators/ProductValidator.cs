using FluentValidation;
using Models;
using System.Collections.Generic;

namespace WinForms.Validators
{
    internal class ProductValidator : AbstractValidator<ProductDataModel>
    {
        public ProductValidator()
        {
            RuleFor(p => p.Model)
                .Cascade(CascadeMode.Stop)
                .NotEmpty().WithMessage("Ingrese el modelo del equipo");
            RuleFor(p => p.Descriptions)
                .Cascade(CascadeMode.Stop)
                .Must(IsValidDescription)
                .WithMessage("Ingrese el nombre del producto o meta-título");
        }

        private bool IsValidDescription(IDictionary<int, DescriptionModel> descriptions)
        {
            foreach (var description in descriptions)
                if (string.IsNullOrWhiteSpace(description.Value.Name) || string.IsNullOrWhiteSpace(description.Value.MetaTitle))
                    return false;
            return true;
        }
    }
}
