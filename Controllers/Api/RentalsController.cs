using AutoMapper;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Http;
using VideoKlub.Dtos;
using VideoKlub.Models;

namespace VideoKlub.Controllers.Api
{
    [Authorize]
    public class RentalsController : ApiController
    {
        private ApplicationDbContext _context;
        public RentalsController()
        {
            _context = new ApplicationDbContext();
        }


        [HttpGet]
        public IEnumerable<RentalDto> GetRentals()
        {

            var rentalsDto = _context.Rentals.Include(r => r.Movies).Include(r => r.User).ToList().Select(Mapper.Map<Rental, RentalDto>);

            if (rentalsDto == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);
                //return NotFound();

            return rentalsDto;

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

            var numberAvailableMovieInDb = _context.Movies.SingleOrDefault(m => m.Id == rentalDto.MovieId).NumberAvailable;
            if (numberAvailableMovieInDb <= 0)
                return BadRequest("No Available Movies");

            var movieInDb = _context.Movies.SingleOrDefault(m => m.Id == rentalDto.MovieId).NumberAvailable--;

            _context.Rentals.Add(rental);
            _context.SaveChanges();

            return Created(new Uri(Request.RequestUri + "/"), rentalDto);
            //return Ok();
        }

        [HttpPut]
        public IHttpActionResult UpdateReturned(int id)
        {
            var rentalInDb = _context.Rentals.SingleOrDefault(r => r.Id == id);

            if (rentalInDb.DateReturned != null)
                return BadRequest("This rental has already been returned.");

            rentalInDb.DateReturned = DateTime.Now;

            _context.Movies.SingleOrDefault(m => m.Id == rentalInDb.MovieId).NumberAvailable++;

            _context.SaveChanges();

            return Ok();
        }
    }
}
