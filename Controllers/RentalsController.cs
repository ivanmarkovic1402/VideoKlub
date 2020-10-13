using System.Linq;
using System.Web.Mvc;
using VideoKlub.Models;
using VideoKlub.ViewModels;

namespace VideoKlub.Controllers
{
    public class RentalsController : Controller
    {
        private ApplicationDbContext _context;
        public RentalsController()
        {
            _context = new ApplicationDbContext();
        }
        // GET: Rentals
        public ActionResult New(int id)
        {
            var movieInDb = _context.Movies.SingleOrDefault(m => m.Id == id);

            if (movieInDb == null)
                return HttpNotFound();

            var genre = _context.Genres.SingleOrDefault(g => g.Id == movieInDb.GenreId);

            var viewModel = new MovieRentalViewModel(movieInDb)
            {
                Genre = genre,
                Users =  _context.Users.ToList()
            };

            return View("NewRental", viewModel);
        }

        public ViewResult ListOfRentals()
        {
            return View();
        }
    }
}