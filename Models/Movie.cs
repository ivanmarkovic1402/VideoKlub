using System;
using System.ComponentModel.DataAnnotations;

namespace VideoKlub.Models
{
    public class Movie
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
        public DateTime DateAdded { get; set; }
        public Genre Genre { get; set; }

        [Required]
        [Display(Name = "Genre")]
        public int GenreId { get; set; }

        public string AddedByUser { get; set; }
    }
}