using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.CrossCuttingConcerns.Validation
{
    public static class ValidationTool
    {
        public static void Validate(IValidator validator,object entity)
        {
            var context = new ValidationContext<object>(entity); // object için doğrulama yapılacak
            var result = validator.Validate(context); // ilgili validator'u kullanarak entity doğrula
            if (!result.IsValid)
            {
                throw new ValidationException(result.Errors);
            }
        }
    }
}
