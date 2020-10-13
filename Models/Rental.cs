using System;

namespace VideoKlub.Models
{
    public class Rental
    {
        public int Id { get; set; }
        public Movie Movies { get; set; }
        public int MovieId { get; set; }
        public string UserId { get; set; }
        public ApplicationUser User { get; set; }
        public DateTime DateRented { get; set; }
        public DateTime? DateReturned { get; set; }
    }
}