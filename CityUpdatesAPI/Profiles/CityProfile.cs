using AutoMapper;

namespace CityUpdatesAPI.Profiles
{
    public class CityProfile : Profile
    {
        public CityProfile() 
        {
            CreateMap<Entities.City, Models.CityWithoutPointsOfInterestDto>();
        }
    }
}
