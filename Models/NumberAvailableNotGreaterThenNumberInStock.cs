using System.ComponentModel.DataAnnotations;

namespace VideoKlub.Models
{
    public class NumberAvailableNotGreaterThenNumberInStock : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var movie = (Movie)validationContext.ObjectInstance;

            if(movie.NumberInStock < movie.NumberAvailable)
                return new ValidationResult("Number of available movies can not be greater then number of movies in stock");

            return ValidationResult.Success;
        }
    }
}