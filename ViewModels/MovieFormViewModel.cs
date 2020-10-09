using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using VideoKlub.Models;

namespace VideoKlub.ViewModels
{
    public class MovieFormViewModel
    {
        public MovieFormViewModel()
        {
            Id = 0;
        }

        public MovieFormViewModel(Movie movie)
        {
            Id = movie.Id;
            Name = movie.Name;
            NumberAvailable = movie.NumberAvailable;
            NumberInStock = movie.NumberInStock;
            GenreId = movie.GenreId;
        }
        public int? Id { get; set; }

        [Required]
        [MaxLength(255)]
        [Display(Name = "Movie Name")]
        public string Name { get; set; }

        [Display(Name = "Number In Stock")]
        public int NumberInStock { get; set; }

        [Display(Name = "Number Available")]
        public int NumberAvailable { get; set; }
        
        public IEnumerable<Genre> Genres { get; set; }

        [Display(Name = "Genre")]
        public int GenreId { get; set; }

        public string Title
        {
            get
            {
                return Id != 0 ? "Edit movie" : "Add movie";
            }
        }

    }
}