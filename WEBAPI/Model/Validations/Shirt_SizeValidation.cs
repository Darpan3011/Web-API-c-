using System.ComponentModel.DataAnnotations;

namespace WEBAPI.Model.Validations
{
    public class Shirt_SizeValidation : ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            var shirt = validationContext.ObjectInstance as Shirt;

            if (shirt != null)
            {
                if (shirt.Gender.Equals("Male", StringComparison.OrdinalIgnoreCase)&&shirt.Size < 8) {
                    return new ValidationResult("Size should be greater then 8");
                } else if (shirt.Gender.Equals("Women", StringComparison.OrdinalIgnoreCase) && shirt.Size < 10)
                {
                    return new ValidationResult("Size should be greater then 10");
                }
            }

            return ValidationResult.Success;
        }
    }
}
