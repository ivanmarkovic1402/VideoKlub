using System.ComponentModel.DataAnnotations;
using VideoKlub.Models;

namespace VideoKlub.Dtos
{
    public class MovieDto
    {
        public int Id { get; set; }


        [Required]
        [MaxLength(255)]
        [Display(Name = "Movie Name")]
        public string Name { get; set; }

        [Display(Name = "Number In Stock")]
        [NumberInStockPositive]
        [NumberAvailableNotGreaterThenNumberInStock]

        public int NumberInStock { get; set; }

        [Display(Name = "Number Available")]
        public int NumberAvailable { get; set; }
        public Genre Genre { get; set; }

        [Display(Name = "Genre")]
        public int GenreId { get; set; }

        public string UserId { get; set; }
        public ApplicationUser User { get; set; }
    }
}