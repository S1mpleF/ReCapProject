﻿using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class CarValidator: AbstractValidator<Car>
    {
        public CarValidator()
        {
            RuleFor(c => c.CarName).NotEmpty();
            RuleFor(c => c.CarName).MinimumLength(2); 
            RuleFor(c => c.DailyPrice).GreaterThan(0);
            RuleFor(c => c.Description).NotEmpty();
            RuleFor(c => c.DailyPrice).GreaterThanOrEqualTo(500).When(c=>c.ModelYear =="2021"); 
        }
    }
}
