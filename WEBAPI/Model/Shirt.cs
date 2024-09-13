using System.ComponentModel.DataAnnotations;
using WEBAPI.Model.Validations;

namespace WEBAPI.Model
{
    public class Shirt
    {
        public int ShirtId { get; set; }
        [Required]
        public string? Brand { get; set; }

        //[Required]
        [Shirt_ColorValidation]
        public required string? Color { get; set; }

        [Required]
        [Shirt_SizeValidation]
        public int Size { get; set; }

        [Required]
        public string Gender { get; set; }

        public double? Price { get; set; }

    }
}
