using EntitiesReCap.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessReCap.ValidationRules.FluentValidation
{
    public class ProductValidator : AbstractValidator<Car>
    {
        public ProductValidator()
        {
            RuleFor(c => c.BrandId).NotEmpty();
            RuleFor(c => c.Description).MinimumLength(5);
            RuleFor(c => c.ModelYear).GreaterThanOrEqualTo(1990).When(c => c.Id == 1);
        }
    }
}
