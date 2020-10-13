using System.Linq;
using System.Net;
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
        public Movie GetMovies(string search)
        {
            var movie = _context.Movies.SingleOrDefault(m => m.Name == search);
            if (movie == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            return movie;
        }
    }
}
