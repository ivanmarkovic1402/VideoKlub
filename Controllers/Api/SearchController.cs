using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using VideoKlub.Models;

namespace VideoKlub.Controllers.Api
{
    public class SearchController : ApiController
    {
        private ApplicationDbContext _context;
        public SearchController()
        {
            _context = new ApplicationDbContext();
        }

        [HttpGet]
        public IEnumerable<Movie> GetMovies(string search)
        {
            //var movies = from m in _context.Movies
            //             where m.Name.Contains(search)
            //             select m;

            var movies = _context.Movies.Where(m => m.Name.Contains(search)).ToList();
            //if (movies == null)
            //    throw new HttpResponseException(HttpStatusCode.NotFound);

            return movies;
        }
    }
}
