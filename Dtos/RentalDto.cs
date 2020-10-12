using System;
using VideoKlub.Models;

namespace VideoKlub.Dtos
{
    public class RentalDto
    {

        public string UserId { get; set; }
        public int MovieId { get; set; }
        public Movie Movie { get; set; }

        public DateTime DateRented { get; set; }
        public DateTime? DateReturned { get; set; }
    }
}