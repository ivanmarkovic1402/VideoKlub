using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using VideoKlub.Models;

namespace VideoKlub.ViewModels
{
    public class MovieRentalViewModel
    {
        public MovieRentalViewModel(Movie movie)
        {
            Id = movie.Id;
            Name = movie.Name;
            NumberAvailable = movie.NumberAvailable;
            GenreId = movie.GenreId;
        }
        public int Id { get; set; }

        [Required]
        [Display(Name = "Movie Name")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Number Available")]
        public int NumberAvailable{ get; set; }

        public Genre Genre { get; set; }

        [Display(Name = "Genre")]
        public int GenreId { get; set; }


        public IEnumerable<ApplicationUser> Users { get; set; }

        //[Display(Name = "Users")]
        //public int UserId { get; set; }
    }
}