using System.ComponentModel.DataAnnotations;

namespace WEBAPI.Model.Validations
{
    public class Shirt_ColorValidation : ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            var shirt = validationContext.ObjectInstance as Shirt;

            if (shirt != null)
            {
                if(shirt.Color.Equals("Red", StringComparison.OrdinalIgnoreCase))
                {
                    return new ValidationResult("Red color not alllowed");
                }
            }

            return ValidationResult.Success;
        }
    }
}
