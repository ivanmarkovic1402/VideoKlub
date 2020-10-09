using System.ComponentModel.DataAnnotations;

namespace VideoKlub.Models
{
    public class NumberInStockPositive : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var movie = (Movie)validationContext.ObjectInstance;

            if (movie.NumberInStock == 0 || movie.NumberInStock < 0)
                return new ValidationResult("Number in stock must be greater then 0");

            return ValidationResult.Success;
        }
    }
}