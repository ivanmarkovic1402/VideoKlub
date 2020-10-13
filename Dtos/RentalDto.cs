using System;
using VideoKlub.Models;

namespace VideoKlub.Dtos
{
    public class RentalDto
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public ApplicationUser User { get; set; }

        public int MovieId { get; set; }
        public MovieDto Movies { get; set; }

        public DateTime DateRented { get; set; }
        public DateTime? DateReturned { get; set; }
    }
}