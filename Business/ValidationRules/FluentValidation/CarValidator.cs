using Entities.Concrate;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class CarValidator : AbstractValidator<Car>
    {
        public CarValidator()
        {
            RuleFor(c => c.BrandId).NotEmpty();
            RuleFor(c => c.ColorId).NotEmpty();
            RuleFor(c => c.Description).MinimumLength(2);
           // RuleFor(c => c.DailyPrice).LessThanOrEqualTo(10);
            RuleFor(c => c.ModelYear).Equals(2018);


        }
    }
}
