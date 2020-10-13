using AutoMapper;
using VideoKlub.Dtos;
using VideoKlub.Models;

namespace VideoKlub.App_Start
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Rental, RentalDto>();
            CreateMap<RentalDto, Rental>();
            CreateMap<Movie, MovieDto>();
            CreateMap<MovieDto, Movie>();
            CreateMap<ApplicationUser, UserDto>();
        }
    }
}