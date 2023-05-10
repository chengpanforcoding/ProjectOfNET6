using ProjectOfNET6.Dtos;
using System.ComponentModel.DataAnnotations;

namespace ProjectOfNET6.ValidationAttributes
{
    public class ProductTitleMustBeDifferentFromDescriptionAttribute : ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            var productDto = (ProductForManipulationDto)validationContext.ObjectInstance;
            if (productDto.Title == productDto.Description)
            {
                return new ValidationResult("產品名稱需要和產品描述不同", new string[] { "ProductForManipulationDto" });
            }
            return ValidationResult.Success;
        }
    }
}
