using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web.Http;
using VideoKlub.Dtos;
using VideoKlub.Models;

namespace VideoKlub.Controllers.Api
{
    public class RentalsController : ApiController
    {
        private ApplicationDbContext _context;
        public RentalsController()
        {
            _context = new ApplicationDbContext();
        }


        [HttpGet]
        public IEnumerable<Rental> GetRentals()
        {
            var rentals = _context.Rentals.ToList();

            if (rentals == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);
                //return NotFound();

            return rentals;

        }


        [HttpGet]
        public IHttpActionResult GetRental(int id)
        {
            var movie = _context.Rentals.SingleOrDefault(r => r.Id == id);

            if (movie == null)
                //throw new HttpResponseException(HttpStatusCode.NotFound);
                return NotFound();

            return Ok(movie);

        }

        [HttpPost]
        public IHttpActionResult CreateRental(RentalDto rentalDto)
        {
            var rental = new Rental();

            rental.MovieId = rentalDto.MovieId;
            rental.UserId = rentalDto.UserId;
            rental.DateRented = DateTime.Now;

            var movieInDb = _context.Movies.SingleOrDefault(m => m.Id == rentalDto.MovieId).NumberAvailable--;

            _context.Rentals.Add(rental);
            _context.SaveChanges();

            //return Created(new Uri(Request.RequestUri + "/"), rentalDto);
            return Ok();
        }
    }
}
